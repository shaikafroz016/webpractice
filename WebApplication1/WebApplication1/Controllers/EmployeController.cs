using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EmployeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Show(int emno,string name)
        {

            List<Emp> li = new List<Emp>();
            Emp e = new Emp();
            e.name = name;
            e.emno = emno;
            li.Add(e);
            return View(li);
        }
    }
}
