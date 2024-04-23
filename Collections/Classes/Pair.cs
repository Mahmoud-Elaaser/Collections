using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public static void Go()
        {
            // Create a pair representing an employee
            var employee = new Pair<int, string>(1, "John Doe");

            // Accessing elements of the pair
            int id = employee.First; // Access the ID (1)
            string name = employee.Second; // Access the name ("John Doe")

            // Display the employee's details
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Name: {name}");

            KeyValuePair<int, string> KVP = new KeyValuePair<int, string>(10000, "BackEnd Developer");
            int salary = KVP.Key;
            string jop = KVP.Value;

            Console.WriteLine($"Employee salary: {salary}");
            Console.WriteLine($"Employee jop: {jop}");
        }
    }

}
