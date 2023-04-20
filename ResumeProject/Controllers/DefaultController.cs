using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {

      
        dbresumeEntities db=new dbresumeEntities();

        public ActionResult About() 
        {
        return View();
        }


        public PartialViewResult PartialBrands() 
        {
            return PartialView();

        
        
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();



        }
        public PartialViewResult PartiaLFooter()
        {
            return PartialView();



        }


        public PartialViewResult PartialSkill() 
        {
            var values=db.Tbl_Skill.ToList();
            return PartialView(values);
        
        }




        public PartialViewResult PartialProjects()
        {
            var values = db.Tbl_Project.ToList();
            return PartialView();
        
        }


        public PartialViewResult PartialCount() 
        {
            ViewBag.skillcount = db.Tbl_Skill.Count();
            ViewBag.servicecount=db.Tbl_Service.Count();
            ViewBag.avgtechnologyvalue = db.Tbl_Technology.Average(x=>x.TechnologyValue);
            ViewBag.happycustomer = 38;
            return PartialView();

        }
        public PartialViewResult TechnologyPartial()
        {
            var values = db.Tbl_Technology.ToList();
            return PartialView(values);
        
        }
        public PartialViewResult PartialService() 
        {
            var values = db.Tbl_Service.ToList();
            return PartialView(values);

        }

        public PartialViewResult PartialAbout()
        {
            var values = db.Tbl_Profile.ToList();
            return PartialView(values);
        
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult partial1() //Büyük bir view'i parçalara ayırmamıza yarıyor bu method
        {
            return PartialView();
        
        }

        public PartialViewResult PartialHeader() 
        {
            return PartialView();
        
        }

        public PartialViewResult PartialNavbar() 
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature() //öne çıkan alan=feautere
        {
            return PartialView();
        }


    }
}