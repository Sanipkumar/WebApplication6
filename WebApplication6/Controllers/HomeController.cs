using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
=======
using WebApplication6.Models;
using WebApplication6.ViewModel;
>>>>>>> Add project files.

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Aboutme()
        {
<<<<<<< HEAD
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
=======
            var personalInfo = GetPersonalInfo();
            var skill = GetSkill();

            var viewModel = new CvViewModel ()
            {
                PersonalInfo = personalInfo,
                Skill = skill
            };

            return View(viewModel);
        }

        private Skill GetSkill()
        {
            return new Skill
            {
                Html = "Advanced",
                CSS = "Intermediate",
                Javascript = "Intermediate",
                Python = "Beginner",
                C_sharp = "Intermediate"
            };
        }

        private PersonalInfo GetPersonalInfo()

        {
            return new PersonalInfo()
            {
                Id = 211015022,
                Name = "Sanip Kumar Das",
                Phone = "01792409921",
                Email = "sanipkumardas@gmail.com",
                Address= "Faridpur",
            };
        }
    }
}
>>>>>>> Add project files.
