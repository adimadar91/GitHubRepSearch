using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        static bool isInit = false;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void addBookmark(string rep)
        {
            if (isInit == false)
            {
                isInit = true;
                Session["bookmarks"] = new List<string>();
            }

            (Session["bookmarks"] as List<string>).Add(rep);

        }
    }
}