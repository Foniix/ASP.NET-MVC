using System;
using Gym.Models;
using Gym.Models.Database;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym.Controllers
{
    public class TrainerController : Controller
    {
        static List<Trainer> _trainers = new List<Trainer>();
        static TrainerController() {
            Database.SetInitializer(new DatabaseInitializer());
        }

        // GET: Trainer
        public ActionResult Index()
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                _trainers = ctx.Trainers.ToList();
            }
            ViewBag.Trainer = _trainers;
            return View();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id is null)
            {
                return new HttpNotFoundResult();
            }
            var trainer = _trainers.FirstOrDefault(p => p.Id == id);
            if (trainer is null)
            {
                return new HttpNotFoundResult();
            }
            ViewBag.Trainer = trainer;

            return View();
        }

        //[HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id is null)
            {
                return new HttpNotFoundResult();
            }
            var trainer = _trainers.FirstOrDefault(p => p.Id == id);
            if (trainer is null)
            {
                return new HttpNotFoundResult();
            }
            ViewBag.Trainer = trainer;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Trainer trainer, HttpPostedFileBase file)
        {
            var editTrainer = _trainers.FirstOrDefault(t => t.Id == trainer.Id);
            if (editTrainer != null)
            {
                editTrainer.FirstName = trainer.FirstName;
                editTrainer.SecondName = trainer.SecondName;
                if (file != null)
                {
                    trainer.Image = $"/Images/{file.FileName}";
                }
                else
                {
                    return new HttpNotFoundResult();
                }
                
                editTrainer.Address = trainer.Address;
                editTrainer.PhoneNumber = trainer.PhoneNumber;
                editTrainer.Specialization = trainer.Specialization;
                editTrainer.Status = trainer.Status;
                editTrainer.WorkingTime = trainer.WorkingTime;
                editTrainer.Gender = trainer.Gender;
                editTrainer.Birthday = trainer.Birthday;
                editTrainer.Email = trainer.Email;
            }

            if(file != null)
            {
                string path = Server.MapPath($"~/Images/{file.FileName}");
                file.SaveAs(path);
            }
            else
            {
                return new HttpNotFoundResult();
            }
            
            using (DatabaseContext ctx = new DatabaseContext())
            {
                ctx.Entry(trainer).State = EntityState.Modified;
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id is null)
            {
                return new HttpNotFoundResult();
            }
            var trainer = _trainers.FirstOrDefault(p => p.Id == id);
            if (trainer is null)
            {
                return new HttpNotFoundResult();
            }
            _trainers.Remove(trainer);
            using (DatabaseContext ctx = new DatabaseContext())
            {
                Trainer p = ctx.Trainers.Find(id);
                ctx.Trainers.Remove(p ?? throw new InvalidOperationException()); // Check Exeptions!
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Trainer trainer, HttpPostedFileBase file)
        {
            if (!ModelState.IsValid)
            {
                ModelState.Clear();
                ModelState.AddModelError("", "");
                if (string.IsNullOrWhiteSpace(trainer.FirstName))
                {
                    ModelState.AddModelError("", "Поле 'FirstName' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.SecondName))
                {
                    ModelState.AddModelError("", "Поле 'LastName' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.PhoneNumber))
                {
                    ModelState.AddModelError("", "Поле 'PhoneNumber' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.Address))
                {
                    ModelState.AddModelError("", "Поле 'Address' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.Specialization))
                {
                    ModelState.AddModelError("", "Поле 'Specialization' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.Status))
                {
                    ModelState.AddModelError("", "Поле 'Status' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.WorkingTime))
                {
                    ModelState.AddModelError("", "Поле 'WorkingTime' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.Gender))
                {
                    ModelState.AddModelError("", "Поле 'Gender' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.Birthday))
                {
                    ModelState.AddModelError("", "Поле 'Birthday' не заполнено");
                }
                if (string.IsNullOrWhiteSpace(trainer.Email))
                {
                    ModelState.AddModelError("", "Поле 'Email' не заполнено");
                }
                return View(trainer);
            }

            string path = Server.MapPath($"~/Images/{file.FileName}");
            file.SaveAs(path);

            var lastPerson = _trainers.LastOrDefault();
            trainer.Id = lastPerson is null ? 1 : lastPerson.Id + 1;
            trainer.Image = $"/Images/{file.FileName}";
            _trainers.Add(trainer);

            using (DatabaseContext ctx = new DatabaseContext())
            {
                ctx.Entry(trainer).State = EntityState.Added;
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}