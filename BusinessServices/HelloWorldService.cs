namespace BusinessServices
{
    public class HelloWorldService : BaseService
    {
        public override string GetGreetings()
        {
            return "Hello World!";
        }
        public override string GetGreetings(string name)
        {
            return "Hello " + name + " from Sethu!";
        }
    }
}