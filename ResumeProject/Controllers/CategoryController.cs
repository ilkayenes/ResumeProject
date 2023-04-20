using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class CategoryController : Controller
    {
       dbresumeEntities db=new dbresumeEntities();
        public ActionResult Index()
        {
            var values=db.Tbl_Category.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        
        }

        [HttpPost]
        public ActionResult AddCategory(Tbl_Category p)
        {
            db.Tbl_Category.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult DeleteCategory(int id) 
        {
            var values = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id) 
        {
            var values=db.Tbl_Category.Find(id);
            return View(values);
        
        
        }

        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category p) 
        {
            var values = db.Tbl_Category.Find(p.CategoryID);
            values.CategoryName=p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");


        
        }
        public ActionResult GetMessageBySubject(int id)
        {
            var values=db.Tbl_Contact.Where(x=>x.Subject==id).ToList();
            return View(values);

          
        
        }

   
        
    }
}