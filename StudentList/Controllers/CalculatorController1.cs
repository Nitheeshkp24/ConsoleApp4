using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentList.Controllers
{
    public class CalculatorController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(int n1,int n2)
        {
            ViewBag.result = n1 + n2;
            return View();
        }

    }
}
