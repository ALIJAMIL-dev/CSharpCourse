using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            Console.ReadLine();
        }
    }

    public interface ILoggingService // Changed to public
    {
        void Log();
    }

    public interface ICachingService // Changed to public
    {
        void Cache();
    }

    public interface IAuthenticationService // Changed to public
    {
        void Authenticate();
    }

    public class Logging : ILoggingService
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    public class Caching : ICachingService
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    public class Authentication : IAuthenticationService
    {
        public void Authenticate()
        {
            Console.WriteLine("Authenticated");
        }
    }

    public class CustomerManager
    {
        private CrossCuttingConcernsFacade _facade;
        public CustomerManager()
        {
            _facade = new CrossCuttingConcernsFacade();
        }

        public void Add()
        {
            _facade.Authentication.Authenticate();
            _facade.Caching.Cache();
            _facade.Logging.Log();
            Console.WriteLine("Customer added");
        }
    }

    public class CrossCuttingConcernsFacade
    {
        public ILoggingService Logging;
        public ICachingService Caching;
        public IAuthenticationService Authentication;
        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authentication = new Authentication();
        }
    }
}
