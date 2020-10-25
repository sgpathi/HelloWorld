using BusinessServices;

namespace Infrastructure
{
    public class DataService : IDataServices
    {
        public string CreateGreetings(string greeting)
        {
            return "Created";
        }

        public string ReadGreetings(string key)
        {
            return "Created";
        }

        public string UpdateGreetings(string greeting)
        {
            return "Created";
        }

        public string DeleteGreetings(string greeting)
        {
            return "Created";
        }
    }
}