using BusinessServices;
using HelloWorld.Controllers;
using HelloWorld.Models;
using Moq;
using Xunit;

namespace Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_GetDefaultGreetings_SuccessTest()
        {
            //Arrange
            var mockHelloWorldService = new Mock<IBusinessService>();
            mockHelloWorldService.Setup(x => x.GetGreetings()).Returns("Hello World from Api Service!");
            var controller = new HomeController(mockHelloWorldService.Object);

            //Act
            var response = controller.DefaultGreetings();

            //Assert
            Assert.Equal("Hello World from Api Service!", response.Value.GreetingMessage);
        }

        [Fact]
        public void HomeController_GetCustomGreeting_SuccessTest()
        {
            //Arrange
            var mockHelloWorldService = new Mock<IBusinessService>();
            mockHelloWorldService.Setup(x => x.GetGreetings(It.IsAny<string>())).Returns("Hello World from Sethu!");
            var controller = new HomeController(mockHelloWorldService.Object);
            var request = new GreetingRequest { Name = "Sethu" };

            //Act
            var response = controller.GetCustomGreeting(request);

            //Assert
            Assert.Equal("Hello World from Sethu!", response.Value.GreetingMessage);
        }
    }
}