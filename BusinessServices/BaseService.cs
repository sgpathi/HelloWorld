using System;

namespace BusinessServices
{
    public class BaseService : IBusinessService
    {
        public virtual string GetGreetings()
        {
            throw new NotImplementedException();
        }

        public virtual string GetGreetings(string name)
        {
            throw new NotImplementedException();
        }
    }
}