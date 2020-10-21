using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentList.Controllers
{
    public class index : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent(string n1,string address)
        {
            ViewBag.name = n1;
            ViewBag.address = address;

            return View();
        }
    }
}
