using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Allprojects()
        {
            return View();
        }

        public ActionResult Myprojects()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreateresumeForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CreateresumeForm(CurriculumVitae curriculumVitae)
        {
            if (ModelState.IsValid)
            {
                return View("YourResumeIsCreate", curriculumVitae);
            }
            else { return View(); }

        }



        [HttpGet]
        public ViewResult CreateyourselfportfolioForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CreateyourselfportfolioForm(Models.Portfolio YourPortfolioIsCreate)
        {
            if (ModelState.IsValid)
            {
                return View("YourPortfolioIsCreate", YourPortfolioIsCreate);
            }
            else { return View(); }
        }

        public ActionResult Opportunities()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

    }
}
