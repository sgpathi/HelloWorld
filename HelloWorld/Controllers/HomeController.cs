using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloWorld.Models;
using BusinessServices;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IBusinessService helloWorldService;

        public HomeController(ILogger<HomeController> logger, IBusinessService helloWorldService)
        {
            _logger = logger;
            this.helloWorldService = helloWorldService;
        }

        public IActionResult Index()
        {
            var greeting = this.helloWorldService.GetGreetings();

            var greetingView = new GreetingViewModel
            {
                GreetingMessage = greeting
            };

            return this.View(greetingView);
        }

        [HttpPost]
        public JsonResult GetCustomGreeting(GreetingRequest request)
        {
            var customGreeting = this.helloWorldService.GetGreetings(request.Name);
            return new JsonResult {
                Data = new { 
                    greeting = customGreeting, ErrorMessage = string.Empty }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
