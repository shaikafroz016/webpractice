using Shopping_portal1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_portal1.DAL
{
    public class DalClass
    {
        ShoppingContext db = new ShoppingContext();
        public bool Login_check(string uname,string pwd)
        {
            bool flag = false;
            User obj = db.Users.Where(x => x.username == uname && x.password == pwd).SingleOrDefault();

            if (obj != null)
            {
                flag = true;
            }
            return flag;
        }
        public bool validate_admin(string text1, string text2)
        {
            bool flag = false;
            User status = db.Users.Where(x => x.username == text1 && x.password == text2 && x.isadmin==true).SingleOrDefault();
            if (status == null)
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public List<Product> product_list()
        {
            return db.Products.ToList();
        }
        public Product prodduct_details(int id)
        {
            Product ob = db.Products.Where(x => x.prdid == id).SingleOrDefault();
            return ob;
        }
    }
}