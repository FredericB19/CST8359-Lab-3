using Lab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Razor()
        {
            return View();
        }

        public IActionResult Count()
        {
            HttpContext.Session.SetString("bottles", Request.Form["bottles"]);

            return View();
        }

        public IActionResult CreatePerson()
        {
            return View();
        }

        public IActionResult DisplayPerson()
        {
            HttpContext.Session.SetString("firstName", Request.Form["firstName"]);
            HttpContext.Session.SetString("lastName", Request.Form["lastName"]);
            HttpContext.Session.SetString("age", Request.Form["age"]);
            HttpContext.Session.SetString("emailAddress", Request.Form["emailAddress"]);
            HttpContext.Session.SetString("dateOfBirth", Request.Form["dateOfBirth"]);
            HttpContext.Session.SetString("description", Request.Form["description"]);

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
