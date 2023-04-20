using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        dbresumeEntities db = new dbresumeEntities();
        public ActionResult Index()
        {
            var value = db.Tbl_Technology.ToList();
            return View(value);
        
        }

        [HttpGet]
        public ActionResult AddTechnology()
        {
            return View();


        }

        [HttpPost]
        public ActionResult AddTechnology(Tbl_Technology p)
        {
            db.Tbl_Technology.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        
        }

        public ActionResult DeleteTechnology(int id) 
        {
            var value = db.Tbl_Technology.Find(id);
            db.Tbl_Technology.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        
        }

        [HttpGet]
        public ActionResult UpdateTechnology(int id) 
        {
            var value = db.Tbl_Technology.Find(id);
            return View(value);
        
        
        }

        [HttpPost]
        public ActionResult UpdateTechnology(Tbl_Technology p)
        {
            var value = db.Tbl_Technology.Find(p.TechnologyID);
            value.TechnologyTitle= p.TechnologyTitle;
            value.TechnologyValue= p.TechnologyValue;
            db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}