using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory1());
            productManager.GetAll();
            Console.WriteLine("--------------------------------------------------");
            Console.ReadLine();
        }
    }

    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            // Log4Net specific logging implementation
            Console.WriteLine($"Log4Net has been Logged");
        }
    }

    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            // nLogger specific logging implementation
            Console.WriteLine($"nLogger has been Logged");
        }
    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }

    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            // MemCache specific caching implementation
            Console.WriteLine($"MemCache has been cached");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            // MemCache specific caching implementation
            Console.WriteLine($"RedisCache has been cached");
        }
    }

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogging();
        public abstract Caching CreateCaching();
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogging()
        {
            return new Log4NetLogger();
        }
        public override Caching CreateCaching()
        {
            return new MemCache();
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogging()
        {
            return new NLogger();
        }
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }
    }

    public class ProductManager
    {
        private CrossCuttingConcernsFactory _factory;

        private Logging _logging;
        private Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _factory = crossCuttingConcernsFactory;
            _logging = _factory.CreateLogging();
            _caching = _factory.CreateCaching();
        }
        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("Data");
            Console.WriteLine("Getting all products...");
        }
    }
}
