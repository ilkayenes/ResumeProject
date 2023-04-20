using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class ProfileController : Controller
    {
        dbresumeEntities db = new dbresumeEntities();

        public ActionResult Index()
        {

            var value = db.Tbl_Profile.ToList();
            return View(value);

        }
        [HttpGet]
        public ActionResult AddProfile()
        {
            return View();


        }

        [HttpPost]

        public ActionResult AddProfile(Tbl_Profile p)
        {
            db.Tbl_Profile.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProfile(int id)
        {
            var value = db.Tbl_Profile.Find(id);
            db.Tbl_Profile.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");


        }

        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = db.Tbl_Profile.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProfile(Tbl_Profile p)
        {
            var value = db.Tbl_Profile.Find(p.ProfileID);
            value.ProfileTitle = p.ProfileTitle;
            value.ProfileDescription = p.ProfileDescription;
            value.Name = p.Name;
            value.Mail = p.Mail;
            value.Address = p.Address;
            value.Phone = p.Phone;
            value.SocialMedia1 = p.SocialMedia1;
            value.SocialMedia2 = p.SocialMedia2;
            value.SocialMedia3  = p.SocialMedia3;
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}