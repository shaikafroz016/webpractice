using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wcfclient_netframe.BAL;

namespace wcfclient_netframe.Controllers
{
    public class EmployController : Controller
    {
        BAL_CLASS bl = new BAL_CLASS();
        // GET: Employ
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult display()
        {
            IList<ServiceReference1.emp> ls =bl.GetRec1();
            return View(ls);
        }
    }
}