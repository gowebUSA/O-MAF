using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using O_MAF.Models;

namespace O_MAF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning!" : "Good Afternoon!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
                        
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        [HttpGet]
        public ViewResult LoginForm()
        {
            return View();
        }
        public ViewResult InitiateForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult LoginForm(LoginResponse loginResponse)
        {
            if (ModelState.IsValid)
            {
                LoginRepository.AddResponse(loginResponse);
                return View("WhoseLogin", loginResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
        public ViewResult InitiateForm(InitiateResponse initiateResponse)
        {
            if (ModelState.IsValid)
            {
                InitiateRepository.AddResponse(initiateResponse);
                return View("Workload", initiateResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
        public ViewResult LoginResponse()
        {
            return View(LoginRepository.Responses);          //LoginRepository.Responses.Where(r => r.WillAttend == true)
        }
        public ViewResult InitiateResponse()
        {
            return View(InitiateRepository.Responses.Where(r => r.AcftUp == true));
        }
    }
}
