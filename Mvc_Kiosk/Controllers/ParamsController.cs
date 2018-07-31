using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Kiosk.Controllers
{
    public class ParamsController : Controller
    {

        livecasinoEntities db = new livecasinoEntities();
  
        public ActionResult Index()
        {
            var item = db.T_CONFIG_VALUES.ToList();

            return View(item);
        }
    }
}
