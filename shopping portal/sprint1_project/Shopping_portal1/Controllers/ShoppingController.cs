using Shopping_portal1.DAL;
using Shopping_portal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping_portal1.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult home_page()
        {
            return View();
        }

        public ActionResult login_controls(string select1)
        {
            string l_type = select1;

            if (l_type == "Admin_User")
            {
                return View("Admin_Login");
            }
            else if (l_type == "Cutomer_User")
            {
                return View("Customer_Login");
            }

            return View("home_page");
        }
        public ActionResult Customer_Login()
        {
            return View();
        }
        DalClass dl = new DalClass();
        public ActionResult prod1(string text1, string text2)
        {
            string uname = text1;
            string pwd = text2;

            bool flag = dl.Login_check(uname, pwd);

            if (flag == true)
            {
                return RedirectToAction("prd_page");
            }
            else
            {
                ViewBag.message1 = "Invalid Username/Password";
                return View("Customer_Login");
            }

            
        }
        public ActionResult Register()
        {
            return RedirectToAction("Create", "Users");
        }
        public ActionResult Admin_Login()
        {
            return View();
        }
        public ActionResult admin_pannel(string text1, string text2)
        {
            bool status = dl.validate_admin(text1, text2);
            if (status == true)
            {
                return RedirectToAction("Index", "Products");
            }
            else
            {
                ViewBag.message = "Invalid Credentials";
                return View("Admin_Login");
            }
        }
        public ActionResult prd_page()
        {
            List<Product> ls = dl.product_list();
            return View(ls);
        }
        public ActionResult prd_details(int prodid)
        {
            Product ob = dl.prodduct_details(prodid);
            return View(ob);
        }
    }
}