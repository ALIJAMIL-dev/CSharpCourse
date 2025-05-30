using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FourProccess fourProccess = new FourProccess(10, 5);
            // Console.WriteLine(fourProccess.Add(3, 4));
            // Console.WriteLine(fourProccess.Add2());

            var type = typeof(FourProccess);
            //FourProccess inpropro = (FourProccess)Activator.CreateInstance(type);
            //FourProccess inpropro = (FourProccess)Activator.CreateInstance(type, 5, 10);
            //Console.WriteLine(inpropro.Add(3, 4));
            //Console.WriteLine(inpropro.Add2());

            var instance = Activator.CreateInstance(type, 5, 10);
            //Console.WriteLine(instance.GetType().GetMethod("Add2").Invoke(instance, null));
            MethodInfo info = instance.GetType().GetMethod("Add2");
            Console.WriteLine(info.Invoke(instance, null));
            Console.WriteLine("----------------------------------------------------");
            var methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine($"Method Name: {item}");
                foreach (var paramMethod in item.GetParameters())
                {
                    Console.WriteLine($"Parameter: {paramMethod}");
                }
                foreach (var attbirute in item.GetCustomAttributes())
                {
                    Console.WriteLine($"Attbirute: {attbirute.GetType().Name}");
                }
            }


            Console.ReadLine();
        }
    }

    public class FourProccess
    {
        int _a;
        int _b;
        public FourProccess(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public FourProccess()
        {

        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Add2()
        {
            return _a + _b;
        }
        public int Multiply2()
        {
            return _a * _b;
        }
        public int Subtract2()
        {
            return _a - _b;
        }
        [MyTestAttribute("Divide")]
        public int Divide2()
        {
            return _a / _b;
        }
    }
    public class MyTestAttribute : Attribute
    {
        public MyTestAttribute(string name)
        {
            
        }
    }
}