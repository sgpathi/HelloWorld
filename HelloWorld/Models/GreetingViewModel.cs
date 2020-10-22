using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class GreetingViewModel
    {
        [Display(Name = "Greeting...")]
        public string GreetingMessage { get; set; }
    }
}