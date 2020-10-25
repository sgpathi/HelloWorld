using System;
using System.Configuration;
using BusinessServices;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBusinessService helloWorldService;

        private IConfiguration configuration;

        private readonly string displayTo;

        public HomeController(IBusinessService helloWorldService, IConfiguration configuration)
        {
            this.helloWorldService = helloWorldService;
            this.configuration = configuration;

            displayTo = this.configuration.GetSection("DisplaySettings")["WriteInfoTo"];
        }

        [HttpGet("/api/greetings")]
        public ActionResult<GreetingResponse> DefaultGreetings()
        {
            var defaultGreeting = this.helloWorldService.GetGreetings();
            
            if (displayTo == "Client")
            {
                return new GreetingResponse { GreetingMessage = defaultGreeting };
            }

            Console.WriteLine(defaultGreeting);

            return new GreetingResponse();
        }

        [HttpPost("/api/greetings")]
        public ActionResult<GreetingResponse> GetCustomGreeting([FromBody] GreetingRequest request)
        {
            var customGreeting = this.helloWorldService.GetGreetings(request.Name);
            return new GreetingResponse { GreetingMessage = customGreeting };
        }
    }
}