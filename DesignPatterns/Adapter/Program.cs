using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class ProductManager
    {
        public void Save()
        {
            Console.WriteLine("Saved!");
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("EdLogger: " + message);
        }
    }
}