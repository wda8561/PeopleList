using PeopleList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleList.Controllers
{
    public class HomeController : Controller
    {
        PeopleContext db = new PeopleContext();
        public ActionResult Index()
        {
            return View(db.People);
        }
        [HttpPost]
        public ActionResult Search(string name, string surname)
        {
            People people = new People();
            people.Name = name;
            people.Surname = surname;
            db.People.Add(people);
            db.SaveChanges();
            return View(db.People);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}