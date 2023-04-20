using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
        dbresumeEntities db=new dbresumeEntities();
        public ActionResult Index()
        {
            var value=db.Tbl_Skill.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddSkill() 
        {
            return View();

        }

        [HttpPost]
        public ActionResult AddSkill(Tbl_Skill p) 
        {
            db.Tbl_Skill.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteSkill(int id) 
        {
            var value=db.Tbl_Skill.Find(id);
            db.Tbl_Skill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id) 
        {
            var value = db.Tbl_Skill.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateSkill(Tbl_Skill p)
        {
            var value = db.Tbl_Skill.Find(p.SkillID); //p deki değerler sayfa post olduğunda gelen yeni değerler güncelleme yaparken ıd yi güncellemediğimiz için burda ıd den gidiyoruz.
            value.SkillTitle=p.SkillTitle;
            value.SkillDescription=p.SkillDescription;
            value.Skillicon=p.Skillicon;
            db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}