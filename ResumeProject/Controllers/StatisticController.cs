using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        dbresumeEntities db=new dbresumeEntities();
        public ActionResult Index()
        {
            //  ViewBag.v = "Merhaba";//Controllerden view'e veri taşımak için kullanılıyor.

            //ViewBag.SkillCount = db.Tbl_Skill.Count();
            ViewBag.ProjeTalebsayi = db.ProjeTalebsayi().FirstOrDefault();   //Procedur kullandık bu proceduru veri tabanında oluşturduk.
            ViewBag.TechnologyCount = db.Tbl_Technology.Count();
            ViewBag.CsharpValue=db.Tbl_Technology.Where(x=>x.TechnologyTitle=="C#").Select(y=>y.TechnologyValue).FirstOrDefault();
            ViewBag.ContactCount=db.Tbl_Contact.Count();
            ViewBag.subjectTesekkür = db.Tbl_Contact.Where(x => x.Subject == 1).Count();
            ViewBag.sumtechnologyvalue = db.Tbl_Technology.Sum(x => x.TechnologyValue);
            ViewBag.averageTechnologyvalue = db.Tbl_Technology.Average(x=>x.TechnologyValue);
            ViewBag.Getby1ID = db.Tbl_Skill.Where(x => x.SkillID == 1).Select(y => y.SkillDescription).FirstOrDefault();
            ViewBag.MaxTechnologyValue = db.Tbl_Technology.Max(x => x.TechnologyValue);
            return View();

        }
    }
}