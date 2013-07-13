using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZulWeb.Controllers
{
    public class MachineController : Controller
    {
        //
        // GET: /Machine/

        public ActionResult Index()
        {
            return View();
        }
             public string Welcome()
             {
            return"This is the Welcome action method...";
            }
    }
}
