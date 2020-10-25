namespace BusinessServices
{
    public class HelloWorldService : BaseService
    {
        /// database service for feature use
        private readonly IDataServices dataServices;

        private const string defaultGreeting = "Hello World from HelloWorldService!";

        public HelloWorldService(IDataServices dataServices)
        {
            this.dataServices = dataServices;
        }

        public override string GetGreetings()
        {
            return defaultGreeting;
        }

        public override string GetGreetings(string name)
        {
            return "Hello " + name + " from Sethu!";
        }
    }
}