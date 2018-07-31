using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Kiosk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            livecasinoEntities db = new livecasinoEntities();
            return View(db.T_GAME_TYPE_CONFIG_VALUES.ToList());
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
    }
}