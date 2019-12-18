using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym.Controllers
{
    public class GymController : Controller
    {
        // GET: Gym
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Halls()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}