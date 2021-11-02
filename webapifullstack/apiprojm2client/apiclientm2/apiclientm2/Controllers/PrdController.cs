using apiclientm2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace apiclientm2.Controllers
{
    public class PrdController : Controller
    {
        // GET: Prd
        Uri baseaddress = new Uri("https://localhost:44380/api/");
        HttpClient client = new HttpClient();


        public PrdController()
        {
            client.BaseAddress = baseaddress;
        }

        public ActionResult getRec()
        {
            List<Product> ls = new List<Product>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Values").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            ls = JsonConvert.DeserializeObject<List<Product>>(data);
            return View(ls);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product obj)
        {

            string data = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response= client.PostAsync(client.BaseAddress + "/Values", content).Result;
            return RedirectToAction("getRec");
        }
        public ActionResult Edit(int id)
        {
            Product obj = new Product();
           HttpResponseMessage response= client.GetAsync(client.BaseAddress + "/Values/" + id).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            obj = JsonConvert.DeserializeObject<Product>(data);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(Product obj)
        {
            string data= JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response= client.PutAsync(client.BaseAddress + "/Values/"+obj.Id, content).Result;
            return RedirectToAction("getRec");
        }
        public ActionResult Details(int id)
        {
            Product obj = new Product();
            HttpResponseMessage response= client.GetAsync(client.BaseAddress + "/Values/" + id).Result;
            string data = response.Content.ReadAsStringAsync().Result;
            obj= JsonConvert.DeserializeObject<Product>(data);
            return View(obj);
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response= client.DeleteAsync(client.BaseAddress + "/Values/" + id).Result;
            return RedirectToAction("getRec");
        }
    }
       

        
}