using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        dbresumeEntities db=new dbresumeEntities();
        public ActionResult Index()
        {
            var values=db.Tbl_Contact.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id) 
        {
            var values = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");


        }


        [HttpGet]

        public ActionResult SendMessage() 
        {
            List<SelectListItem> values = (from x in db.Tbl_Category.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()


                                           }).ToList();

            ViewBag.v=values;
            return View();             
                                    

            //bunu listelemek için yapıyoruz categoryi listeleyip x'e atıyoruz xi'de values a eşitliyoruz. dropdown açıldığında isimler gözüküyor burda 


        }

        [HttpPost]
        public ActionResult SendMessage(Tbl_Contact p) 
        
        {
            p.Date=DateTime.Parse(DateTime.Now.ToString());//mesajı gönderdiği anı göstericek
            db.Tbl_Contact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Default");


        }


        








        public PartialViewResult PartialMap() 
        {
            return PartialView();
        
        
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();


        }






    }
}