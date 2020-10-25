namespace BusinessServices
{
    public interface IBusinessService
    {
        string GetGreetings();

        string GetGreetings(string name);
    }
}