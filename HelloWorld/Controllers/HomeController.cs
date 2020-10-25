using BusinessServices;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBusinessService helloWorldService;

        public HomeController(IBusinessService helloWorldService)
        {
            this.helloWorldService = helloWorldService;
        }

        [HttpGet("/api/greetings")]
        public ActionResult<GreetingResponse> DefaultGreetings()
        {
            var defaultGreeting = this.helloWorldService.GetGreetings();

            return new GreetingResponse { GreetingMessage = defaultGreeting };
        }

        [HttpPost("/api/greetings")]
        public ActionResult<GreetingResponse> GetCustomGreeting([FromBody] GreetingRequest request)
        {
            var customGreeting = this.helloWorldService.GetGreetings(request.Name);
            return new GreetingResponse { GreetingMessage = customGreeting };
        }
    }
}