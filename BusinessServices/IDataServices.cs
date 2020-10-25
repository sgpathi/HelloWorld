namespace BusinessServices
{
    public interface IDataServices
    {
        string CreateGreetings(string greeting);

        string ReadGreetings(string key);

        string UpdateGreetings(string greeting);

        string DeleteGreetings(string greeting);
    }
}