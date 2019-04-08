using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("home")]
        public ViewResult Index()
        {
            return View("index");
        }
        [HttpPost("results")]
        public ViewResult Results(string name, string location, string comment,string stack){
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.comment = comment;
            ViewBag.stack = stack;            
            return View("results");
        } 

        [HttpGet("time")]
        public DateTime = Cu
        // [HttpPost("postingdata")]
        // public IActionResult postingdata(string name, string location, string comment, string stack){
        //     return RedirectToAction("results");
        // }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
