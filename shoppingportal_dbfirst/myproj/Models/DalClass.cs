using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myproj.DAL
{
    public class DalClass
    {
        myprojEntities db = new myprojEntities();
        public void Register(cust obj)
        {
            db.custs.Add(obj);
            db.SaveChanges();
        }

        public bool Login_check(string uname, string pwd)
        {
            bool flag = false;
            cust obj = db.custs.Where(x => x.usrname == uname && x.pwd == pwd).SingleOrDefault();

            if (obj != null)
            {
                flag = true;
            }
            return flag;
            
        }

        public List<product> product_list()
        {
            return db.products.ToList();
        }
        public product prodduct_details(int id)
        {
            product ob = db.products.Where(x => x.prodid == id).SingleOrDefault();
            return ob;
        }
        public product product_update(product ob)
        {
            product obj = db.products.Where(x => x.prodid == ob.prodid).SingleOrDefault();
            obj.prodname = ob.prodname;
            obj.prodcatg = ob.prodcatg;
            obj.prodprice = ob.prodprice;
            db.SaveChanges();
            return (obj);
        }
        public bool delete_prod(int id)
        {
            bool flag = true;
            product ob= db.products.Where(x => x.prodid == id).SingleOrDefault();
            db.products.Remove(ob);
            db.SaveChanges();
            return flag;
        }
        public void add_prd(product ob)
        {
            db.products.Add(ob);
            db.SaveChanges();
        }

        public bool validate_admin(string text1, string text2)
        {
            bool flag=false;
            admi status = db.admis.Where(x => x.adname == text1 && x.adpass == text2).SingleOrDefault();
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
    }
}