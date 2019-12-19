using Gym.Models;
using Gym.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym.Controllers
{
    public class TrainerController : Controller
    {
        static List<Trainer> trainers = new List<Trainer>();
        static TrainerController() {
            Database.SetInitializer(new DatabaseInitializer());
        }

        // GET: Trainer
        public ActionResult Index()
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                trainers = ctx.Trainers.ToList();
            }
            ViewBag.Trainer = trainers;
            return View();
        }
    }
}