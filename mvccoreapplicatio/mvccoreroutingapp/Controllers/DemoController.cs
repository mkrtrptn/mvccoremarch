using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvccoreroutingapp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult getinfobyid(int id)
        {
            ViewBag.info = id + "Product";
            return View();
        }

        public ActionResult getinfobyidname(int id , int name)
        {
            ViewBag.info = id + name + "Product";
            return View();
        }


    }
}