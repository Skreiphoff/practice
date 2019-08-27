using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameSite.Models
{
    public class User
    {
        [Key]
        public int ID_User { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public DateTime Date_of_issue { get; set; }
        public int Reputation { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Love_tag { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

    }
    public class Game
    {
        [Key]
        public int ID_game { get; set; }
        public string Name_game { get; set; }
        public DateTime Year_of_release { get; set; }
        public string Tag { get; set; }
        public string Developer { get; set; }
        public int Game_Rathing { get; set; }

    }
    public class Game_description
    {
        [Key]
        public int ID_game { get; set; }
        public string Description { get; set; }
        public string URL_game { get; set; }
        public string URL_img { get; set; }
        public string URL_trailer { get; set; }

    }
    public class Comments
    {
        [Key]
        public int ID_comment { get; set; }
        public string Comment { get; set; }
        public DateTime Date_comment { get; set; }
        public int ID_User { get; set; }
        public int ID_game { get; set; }
        public int GameRating { get; set; }
    }
}
