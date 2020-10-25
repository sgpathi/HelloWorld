using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class GreetingResponse
    {
        [Display(Name = "Greeting...")]
        public string GreetingMessage { get; set; }
    }
}