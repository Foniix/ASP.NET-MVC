using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gym.Models;
using Gym.Models.Database;

namespace Gym.Controllers
{
    public class GymController : Controller
    {
        static List<Hall> halls = new List<Hall>();

        static GymController()
        {
            Database.SetInitializer(new DatabaseInitializer());

        }
        // GET: Gym
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Halls()
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                halls = ctx.Halls.ToList();
            }
            ViewBag.Halls = halls;
            ;
            return View();
        }

        //[Authorize(Roles = "admin")]
        
    }
}