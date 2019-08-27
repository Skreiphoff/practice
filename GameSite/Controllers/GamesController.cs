using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameSite.Controllers
{
    public class GamesController : Controller
    {
        private UsersContext db;
        public GamesController(UsersContext context)
        {
            db = context;
        }



        public IActionResult Search(string genres, string searchString)
        {
            ViewData["genre"] = genres;
            ViewBag.game = searchString;
            var GenreQry = from m in db.Game
                           orderby m.Tag
                           select m.Tag;

            var games = from m in db.Game
                        select m;
            if (genres != null)
            {
                foreach (var g in games)
                {
                    if (!String.IsNullOrEmpty(genres))
                    {
                        games = games.Where(x => x.Tag == genres);
                    }
                }
            }
            else
            {
                foreach(var g in games)
                {
                    if (!String.IsNullOrEmpty(genres))
                    {
                        games = games.Where(x => x.Name_game == searchString);
                    }
                }
            }

            return View(games);
        }

        public IActionResult Content (string text)
        {
            var GenreQry = from game in db.Game
                           join desc in db.Game_description
                           on game.ID_game equals desc.ID_game
                           where game.Name_game == text
                           select new { Name = game.Name_game, Dev = game.Developer, Release = game.Year_of_release, Genre = game.Tag, Rathing = game.Game_Rathing, Desc = desc.Description, Img = desc.URL_img, Video = desc.URL_trailer };
            var games = new List<string>();

            if (!String.IsNullOrEmpty(text))
            {
                GenreQry = GenreQry.Where(x => x.Name == text);
            }

            foreach (var Game in GenreQry)
            {
                ViewData["Game"] = Game.Name;
                ViewData["Dev"] = Game.Dev;
                ViewData["Release"] = Game.Release.ToShortDateString();
                ViewData["Genre"] = Game.Genre;
                ViewData["Rathing"] = Game.Rathing;
                ViewData["Description"] = Game.Desc;
                ViewData["Image"] = Game.Img;
                ViewData["Video"] = Game.Video;
            }

            return View();
        }
    }
}
