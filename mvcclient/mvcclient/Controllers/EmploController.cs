using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcclient.Controllers
{
    public class EmploController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
