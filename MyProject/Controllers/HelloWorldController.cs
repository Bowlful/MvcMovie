﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MyProject.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET : /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET : /HelloWorld/Welcome
        public IActionResult Welcome(String name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
