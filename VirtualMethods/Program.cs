using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default!");
            }
            public virtual void Delete()
            {
                Console.WriteLine("Delete by default!");
            }
        }
        class SqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by SQL");
                //base.Add();
            }
        }
        class MySQL : Database
        {

        }
    }
}
