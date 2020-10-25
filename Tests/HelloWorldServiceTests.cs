using BusinessServices;
using Moq;
using Xunit;

namespace Tests
{
    public class HelloWorldServiceTests
    {
        [Fact]
        public void HelloWorldServiceTests_GetDefaultGreetings_SuccessTest()
        {
            //Arrange
            var mockDataServices = new Mock<IDataServices>();
            var helloWorldService = new HelloWorldService(mockDataServices.Object);

            //Act
            var response = helloWorldService.GetGreetings();

            //Assert
            Assert.Equal("Hello World from HelloWorldService!", response);
        }

        [Fact]
        public void HelloWorldServiceTests_GetCustomGreeting_SuccessTest()
        {
            //Arrange
            var mockDataServices = new Mock<IDataServices>();
            var helloWorldService = new HelloWorldService(mockDataServices.Object);

            //Act
            var response = helloWorldService.GetGreetings("Dave");

            //Assert
            Assert.Equal("Hello Dave from Sethu!", response);
        }
    }
}