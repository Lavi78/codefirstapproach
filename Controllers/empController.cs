using codefirstapproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codefirstapproach.Models;

namespace codefirstapproach.Controllers
{
    public class empController : Controller
    {
        Aplicationdbcontext obj = new Aplicationdbcontext();
        // GET: emp
        public ActionResult Index()
        {
            List<emp> emp = obj.emps.ToList();
            return View(emp);
        }
        [HttpGet]
        public ActionResult create()
        {
            
            return View();
        }
        [HttpPost]
        
        public ActionResult Create(string name,string add,int salary,string phn)
        {
            emp obj1 = new emp()
            {
               
                name = name,
                add = add,
                salary = salary,
                phn = phn
            };
           obj.emps.Add(obj1);
            obj.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}