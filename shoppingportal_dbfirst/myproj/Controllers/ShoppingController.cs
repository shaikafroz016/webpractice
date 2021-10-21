using myproj.DAL;
using System.Collections.Generic;
using System.Web.Mvc;

namespace myproj
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

        public ActionResult Admin_Login()
        {
            return View();
        }
        public ActionResult admin_pannel(string text1,string text2)
        {
            bool status = dl.validate_admin(text1, text2);
            if (status == true)
            {
                return RedirectToAction("prd_page_admin");
            }
            else
            {
                return Content("invalid username/password");
            }
        }

        public ActionResult Customer_Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        DalClass dl = new DalClass();
        public ActionResult Register1(string text1, string text2, string text4, string text5, string text6)
        {

            cust obj = new cust();
            obj.userid = 1002;
            obj.usrname = text1;
            obj.pwd = text2;
            obj.address1 = text4;
            obj.email = text5;
            obj.mobile = text6;
            dl.Register(obj);
            return View("Customer_Login");
        }

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
                return RedirectToAction("home_page");
            }

            ViewBag.status = "Invalid Usernam/Password";
            return View("Customer_Login");
        }

        public ActionResult prd_page()
        {
            List<product> ls= dl.product_list();
            return View(ls);
        }
        public ActionResult prd_details(int prodid)
        {
            product ob = dl.prodduct_details(prodid);
            return View(ob);
        }
        public ActionResult prd_page_admin()
        {
            List<product> ls = dl.product_list();
            return View(ls);
        }
        public ActionResult add_product()
        {
            return View();
        }
        public ActionResult add_product1(int id, string prdname, string prdc, string prdpr)
        {
            product ob = new product();
            ob.prodid = id;
            ob.prodname = prdname;
            ob.prodcatg = prdc;
            ob.prodprice = prdpr;
            dl.add_prd(ob);
            return RedirectToAction("prd_page_admin");
        }
        public ActionResult prd_details_admin(int prodid,string a)
        {
            if (a == "edit")
            {
                product ob = dl.prodduct_details(prodid);
                
                return View(ob);
            }
            else if(a== "delete")
            {
                dl.delete_prod(prodid);
                return Content("Deleted succes");
            }
            return Content("hmmmmm");
        }
        public ActionResult prd_updtae(int id,string prdname,string prdc,string prdpr)
        {
            product ob = new product();
            ob.prodid = id;
            ob.prodname = prdname;
            ob.prodcatg = prdc;
            ob.prodprice = prdpr;
            dl.product_update(ob);
            ViewBag.status = "detail updated success...";
            return Content("success...");
        }
       public ActionResult prd_admin_upd()
        {
            return View();
        }
        public ActionResult prd_admin_del()
        {
            return View();
        }

    }
}