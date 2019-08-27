using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameSite.Models;
using GameSite.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using System.Data.SqlClient;

namespace GameSite.Controllers
{
    public class AccountController : Controller
    {
        
        private UsersContext db;
        public AccountController(UsersContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(model.Login); // аутентификация
                    return RedirectToAction("Cabinet", "Account", new { model.Login });
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            

            return View(model);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Login == model.Login);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    db.Users.Add(new User {Name = model.Name, Surname = model.Surname,Nickname= model.Nickname, Date_of_issue = model.Date_of_issue, Reputation = 0, Login = model.Login, Password = model.Password, Love_tag = model.Love_tag ,Role = "User", Email = model.Email});
                    await db.SaveChangesAsync();
                    await Authenticate(model.Login); // аутентификация
                    return RedirectToAction("Cabinet", "Account", new { model.Login });
                }
                else
                    ModelState.AddModelError("", "Такой пользователь существует");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


      
        
    public IActionResult Cabinet(string Login)
        {
            ViewData["Message"] = Login;
            string sql = "select * from Users where Login = '" + Login + "'";
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QKJQU4RE\\MYSERVER;Database=GameSite;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                        string surname = reader.GetString(2);
                        string nickname = reader.GetString(3);
                        int rep = reader.GetInt32(5);
                        string role = reader.GetString(9);
                        string lt = reader.GetString(8);
                        string email = reader.GetString(10);

                        ViewData["Name"] = name;
                        ViewData["Surname"] = surname;
                        ViewData["Nickname"] = nickname;
                        ViewData["Rep"] = rep;
                        ViewData["Role"] = role;
                        ViewData["lt"] = lt;
                        ViewData["log"] = Login;
                        ViewData["email"] = email;
                    }
                }
            }
            return View();
        }
        /*public IActionResult Switch(string genres, string Login)
        {
            ViewData["Login"] = Login;
            string sql = "UPDATE Users SET Love_tag ='" + genres + "' where Login = '" + Login + "'";
            if (genres != null)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QKJQU4RE\\MYSERVER;Database=GameSite;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return View();
        }*/
    }
}
