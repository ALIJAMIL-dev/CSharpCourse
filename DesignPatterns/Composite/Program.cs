using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Employee { Name = "Manager" };
            Employee employee1 = new Employee { Name = "Employee 1" };
            Employee employee2 = new Employee { Name = "Employee 2" };
            manager.AddSubordinate(employee1);
            manager.AddSubordinate(employee2);
            Console.WriteLine($"{manager.Name} has the following subordinates:");
            foreach (var subordinate in manager)
            {
                Console.WriteLine($"- {subordinate.Name}");
            }
            Contractor contractor = new Contractor { Name = "Contractor 1" };
            employee1.AddSubordinate(contractor);
            // Example of removing a subordinate
            manager.RemoveSubordinate(employee1);
            Console.WriteLine($"{manager.Name} after removing {employee1.Name}:");
            foreach (var subordinate in manager)
            {
                Console.WriteLine($"- {subordinate.Name}");
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string Name { get; set; }
    }
    class Contractor : IPerson
    {
        public string Name { get; set; }
    }

    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var person in _subordinates)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
