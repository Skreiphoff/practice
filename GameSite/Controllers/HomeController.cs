using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GameSite.Models;

namespace GameSite.Controllers
{
    public class HomeController : Controller
    {
        private UsersContext db;
        public HomeController(UsersContext context)
        {
            db = context;
        }


        public IActionResult Index(string genres, string SearchString)
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
