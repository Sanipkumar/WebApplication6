using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class MyselfController : Controller
    {
        // GET: Myself
        public ActionResult Index()
        {
            return View();
        }
    }
}