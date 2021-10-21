using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapiproj.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        EmpEntities db = new EmpEntities();
        public List<emp> Get()
        {
            List<emp> li = db.emps.ToList();
            return li;
        }

        // GET api/values/5
        public emp Get(int id)
        {
            var ob = db.emps.Where(x => x.empno == id).SingleOrDefault();
            return ob;
        }

        // POST api/values
        public void Post([FromBody] emp value)
        {
            db.emps.Add(value);
            db.SaveChanges();
        }

        // PUT api/values/5
        public emp Put(int id, [FromBody] emp value)
        {
            var ob = db.emps.Find(id);
            ob.empname = value.empname;
            ob.job = value.job;
            ob.deptno = value.deptno;
            ob.salary = value.salary;
            ob.empno = id;
            db.SaveChanges();
            return ob;
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            var ob = db.emps.Find(id);
            db.emps.Remove(ob);
            db.SaveChanges();
            return "delete success..";
        }
    }
}
