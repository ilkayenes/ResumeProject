using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ProjectController : Controller
    {
        dbresumeEntities db=new dbresumeEntities();
        public ActionResult Index()
        {
            var value = db.Tbl_Project.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddProject()
        {
            return View();

        
        }

        [HttpPost]
        public ActionResult AddProject(Tbl_Project p)
        {
            db.Tbl_Project.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");



        }


        public ActionResult DeleteProject(int id) 
        {
            var value=db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateProject(int id) 
        {
        var value=db.Tbl_Project.Find(id);
            return View(value);

        
        }

        [HttpPost]
        public ActionResult UpdateProject(Tbl_Project p)
        {
            var value = db.Tbl_Project.Find(p.ProjectID);
            value.ProjectTitle = p.ProjectTitle;
            value.ProjectDescription = p.ProjectDescription;
            value.ProjectImageUrl=p.ProjectImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}