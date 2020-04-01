using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace OMAF.Controllers
{
    public class HelloOmafController : Controller
    {
        // 
        // GET: /HelloWOmaf/
        public IActionResult Index()
        {
            return View();
        }
        public string Index1()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWOmaf/Welcome/ 
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public string Welcome3(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        public string Welcome2(string name, int numTimes = 1)            //?name=Rick&numtimes=4
            //The ? (question mark) in the above URL is a separator, and the query string follows. 
            //The & character separates field-value pairs.
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        public string Welcome1()
        {
            return "This is the Welcome action method...";
        }
    }
}