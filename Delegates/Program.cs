using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegateWithParam(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // customerManager.ShowAlert();
            // customerManager.SendMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; // Multicast delegate 
            myDelegate -= customerManager.SendMessage;

            MyDelegateWithParam myDelegateWithParam = customerManager.SendMessage2;
            myDelegateWithParam += customerManager.ShowAlert2;
            myDelegateWithParam("He");
            myDelegate();
            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Message Sent");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string text)
        {
            Console.WriteLine(text);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
}
