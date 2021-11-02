using apiproj.DAL;
using apiproj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiproj.Controllers
{
    public class ValuesController : ApiController
    {
        productcontext db = new productcontext();
        // GET api/values
        public List<Products> Get()
        {
            return db.Products.ToList();
        }

        // GET api/values/5
        public Products Get(int id)
        {
            var obj = db.Products.Find(id);
            return obj;
        }

        // POST api/values
        public void Post([FromBody] Products value)
        {
            db.Products.Add(value);
            db.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] Products value)
        {
            var ob =db.Products.Find(id);
            ob.prd_name = value.prd_name;
            ob.prd_catg = value.prd_catg;
            ob.price = value.price;
            ob.desc = value.desc;
            ob.Id = id;
            db.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var ob = db.Products.Find(id);
            db.Products.Remove(ob);
            db.SaveChanges();
        }
    }
}
