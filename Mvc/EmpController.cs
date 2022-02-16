using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample1.Controllers
{
    public class EmpController : Controller
    {
        // GET:
        //Emp
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string name = collection["txtname"].ToString();
            Session["name"] = name;
            return View();
        }
    }
}