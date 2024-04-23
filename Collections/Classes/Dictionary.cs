using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Dictionary
    {
        // Dictionary = map in C++
        public static void Go()
        {
            // Create a Dictionary with string keys and int values
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();

            // Add key-value pairs to the Dictionary
            studentGrades["Alice"] = 90;
            studentGrades["Bob"] = 85;
            studentGrades["Charlie"] = 60;
            // add a paire of elemnts to this Dictionary
            studentGrades.Add("David", 70);
            studentGrades.Add("Tourist", 100);

            // Print the Dictionary
            Console.WriteLine("Original Dictionary:");
            PrintDictionary(studentGrades);

            // a new way to create a dictionary
            var friends = new Dictionary<int, string>()
            {
                {19, "Ahmad"}, // "Key Here" is not index just a number 
                {24, "Muhammed"},
                {93, "Mahmoud"},
                {42, "Mostafa"},
                {58, "Ibrahim"}
            };
            Console.WriteLine("--------------------------");
            for (int i = 0; i < friends.Count; ++i)
            {
                Console.Write("Friend name is: ");
                Console.WriteLine(friends[friends.Keys.ElementAt(i)]);
                // just a simulate==> at i = 2  friends[2] => his value is Mahmoud
            }

            // another way to create a dictionary
            var myFriends = new Dictionary<string, int>()
            {
                ["Osama"] = 100,
                ["Abdo"]  = 200,
                ["Ayman"] = 300,
                ["Fawzy"] = 400
            };
            myFriends.Add("Esmail", 500);
            myFriends.Add("Ali", 600);

            Console.WriteLine("----------------------------");
            PrintDictionary(myFriends);

            // Creating a new Dictionary from another Dictionary
            Console.WriteLine("------Creating a dictionary from another dictionary------");
            Dictionary<string, int> copDictionary = new Dictionary<string, int>(myFriends);
            PrintDictionary(copDictionary);
            Console.WriteLine("------New way to Create a dictionary from another dictionary------");
            var anotherDictionary = studentGrades.ToDictionary();
            PrintDictionary(anotherDictionary);

            Console.WriteLine("--------------------------");
            // Check if a key exists in the Dictionary
            bool containsKey = studentGrades.ContainsKey("Bob");
            Console.WriteLine("Does the Dictionary contain key 'Bob'? " + containsKey);
            bool containsValue = studentGrades.ContainsValue(100);
            Console.WriteLine("Does the Dictionary contain value 100? "+containsValue);
            // Access a value using a key
            Console.WriteLine("------Access elements------");
            int aliceGrade = studentGrades["Alice"];
            Console.WriteLine("Grade of Alice: " + aliceGrade);

            // Modify the value associated with a key
            studentGrades["Charlie"] = 95;
            Console.WriteLine("------Dictionary after modification------");
            PrintDictionary(studentGrades);

            //Ordering Dictionary
            Console.WriteLine("------Ordering Dictionary Ascending By Linq----");
            var orderedByKey = friends.OrderBy(x => x.Key);
            foreach(var it in orderedByKey)
            {
                Console.WriteLine($"Friend Id is: {it.Key} and his name is: {it.Value}");
            }

            // Remove a key-value pair from the Dictionary
            studentGrades.Remove("Bob");
            friends.Remove(93); // take key, here <int,string> key is "int" 
            // Print the Dictionary after removal
            Console.WriteLine("------Dictionary after removal------");
            PrintDictionary(studentGrades);
            for(int i = 0; i < friends.Count; ++i)
            {
                Console.Write("Friend name is: ");
                Console.WriteLine(friends[friends.Keys.ElementAt(i)]);
            }

            //Convert Dictionary to string
            Console.WriteLine("-----Convert Dictionary to string-----");
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var it in friends)
            {
                stringBuilder.Append($"Name is: {it.Value} and his id is: {it.Key} ");
            }
            Console.WriteLine(stringBuilder);

            Console.WriteLine();

            //!!!! IMPORTANT Dictionary of complex types
            Console.WriteLine("-!!!-----Dictionary of complex types-----!!!-");
            var employeeDictionary = new Dictionary<int, Employee>();
            // Empty Constructor
            employeeDictionary.Add(1, new Employee()
            {
                EmployeeNo = 1,
                FullName = "Mahmoud Diab",
                Job = "Developer",
                StartSalary = 1000,
                WorkingHoursPerWeek = 20,
                contract = Contract.FullTime

            });
            // Parameterized Constructor
            employeeDictionary.Add(2, new Employee(100, "Ahmed Khairy", "Tester", 8000, 45, Contract.FullTime));

            //print employeeDictionary
            foreach (var it in employeeDictionary)
            {
                Console.WriteLine($"Key is: ({it.Key}) and value is: {it.Value}, " +
                    $"Employee Name is: {it.Value.FullName} and he is: {it.Value.Job} " +
                    $"Start salary is: {it.Value.StartSalary} " +
                    $"and he is working {it.Value.WorkingHoursPerWeek} per week " +
                    $"and he works as {Contract.FullTime}");
            }

            //Sorted Dictionary doesn't contain duplicate values
            Console.WriteLine("------Sorted Dictionary------");
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>(friends);
            foreach(var it in sortedDictionary)
            {
                Console.WriteLine($"Key is: {it.Key}, Value is: {it.Value} ");
            }

            // SortedDictionary in complex types
            Console.WriteLine("------SortedDictionary in complex types------");
            var complexSortedDictionary = new SortedDictionary<int, Employee>();
            complexSortedDictionary.Add(1, new Employee()
            {
                EmployeeNo = 210,
                FullName="Youssef",
                Job="Developer",
                StartSalary = 10000,
                WorkingHoursPerWeek = 20,
                contract = Contract.FullTime
            });

            complexSortedDictionary.Add(2, new Employee(210, "Eslam", "Frontend", 7000, 30, Contract.PartTime));

            //Display SortedDictionary in complex types
            foreach(var it in complexSortedDictionary)
            {
                Console.WriteLine($"Key is ({it.Key}), value is: {it.Value},\nEmployee number is: {it.Value.EmployeeNo},\n" +
                    $"his Name is: {it.Value.FullName},\n" +
                    $"his job is: {it.Value.Job},\n" +
                    $"Starting Salary is: {it.Value.StartSalary},\n" +
                    $"He works {it.Value.WorkingHoursPerWeek} per week,\n" +
                    $"He works as: {Contract.Casual}");
            }

            //LOOK:) a new way of implementation
            //anther way to print SortedDictionary in complex types
            Console.WriteLine("---anther way to print SortedDictionary in complex types---");
            foreach (KeyValuePair<int,Employee> it in complexSortedDictionary)
            {
                Console.WriteLine($"Key is ({it.Key}), value is: {it.Value},\nEmployee number is: {it.Value.EmployeeNo},\n" +
                    $"his Name is: {it.Value.FullName},\n" +
                    $"his job is: {it.Value.Job},\n" +
                    $"Starting Salary is: {it.Value.StartSalary},\n" +
                    $"He works {it.Value.WorkingHoursPerWeek} per week,\n" +
                    $"He works as: {Contract.Casual}");
            }



            // Display Keys only
            Console.WriteLine("---Display Keys only---");
            foreach (int it in complexSortedDictionary.Keys)
            {
                Console.WriteLine($"Key is: {it}");
            }



        }

        // Helper method to print the elements of the Dictionary
        static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach (var it in dictionary)
            {
                Console.WriteLine($"{it.Key}: {it.Value}");
            }
        }

    }
    
}
