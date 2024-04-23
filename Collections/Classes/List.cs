using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class List
    {
        public static void Go()
        {

            // Create a List of integers
            List<int> numbers = new List<int>();
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            var list2 = new List<int>() { 6, 7, 8, 9, 10 };

            Console.WriteLine($"First index of list is: {list[0]}");
            Console.WriteLine($"Last index of list is: {list[list.Count - 1]}");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.WriteLine("-------------------");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i] + " ");
            }


            // Add elements to the List
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);

            // Print the List
            Console.WriteLine("---------Original List--------");
            Displaying.Display(numbers);


            // Insert an element at a specific index
            numbers.Insert(2, 25);  // index => 2 and value => 25


            // Print the List after insertion
            Console.WriteLine("\nList after insertion:");
            Displaying.Display(numbers);


            // Remove an element by value
            numbers.Remove(15);


            // Print the List after removal
            Console.WriteLine("\nList after removal:");
            Displaying.Display(numbers);


            //Copying list into array
            int[] arr = new int[5];
            list.CopyTo(arr, 0); // 0 => starting index
            Console.WriteLine("-----Copying list into array------");
            Displaying.Display(arr);


            //Copying list into another list
            List<int> list3 = new List<int>() { 100, 200, 300, 400, 500 };
            var copList = new List<int>(list3);
            Console.WriteLine("-----Copying list into another list------");
            Displaying.Display(copList);


            // short list
            var shortList = list.GetRange(0, 4); // index from -> to  (0,1,2,3)
            Console.WriteLine("-----Short list------");
            Displaying.Display(shortList);


            // Check if the List contains a specific value
            bool containsValue = numbers.Contains(10);
            Console.WriteLine("\nDoes the List contain 10 \n" + containsValue);


            // Find the index of a specific value
            int index = numbers.IndexOf(25);
            Console.WriteLine("Index of 25: " + index);


            // Sort the List
            numbers.Sort();


            // Print the List after sorting
            Console.WriteLine("\nList after sorting:");
            Displaying.Display(numbers);


            //INPORTANT!!!--- Creating list of complex types-----!!!
            Console.WriteLine("!!!---Creating list of complex types---!!!");
            List<Employee> emplyeeList = new List<Employee>();
            //Empty Constructor
            emplyeeList.Add(new Employee()
            {
                EmployeeNo = 800,
                FullName = "Muhammed Esmail",
                Job = "Software Engineer",
                StartSalary = 9000,
                WorkingHoursPerWeek = 10,
                contract = Contract.Casual
            }); ;
            //parameterized Constructor
            emplyeeList.Add(new Employee(900, "Ahmed Muhammed", "Fullstack Developer", 8700, 15, Contract.Freelance)); 

            //print employee List
            foreach (var it in emplyeeList)
            {
                Console.WriteLine($"Employee Number is: {it.EmployeeNo}, " +
                    $"his name is: {it.FullName}, " +
                    $"his jop is: {it.Job}, " +
                    $"his starting salary is: {it.StartSalary}, " +
                    $"he works {it.WorkingHoursPerWeek} per week, " +
                    $"and he works as: {it.contract}");
            }

            // Sorted List ==> sort list by key
            Console.WriteLine("------Sorted List------");
            SortedList<string, string> sortedList = new SortedList<string, string>();
            sortedList.Add("Watermelon", "200");
            sortedList.Add("Banana", "500");
            sortedList.Add("Orange", "300");
            sortedList.Add("Apple", "1000");

            foreach (var it in sortedList)
            {
                Console.WriteLine($"Key is: {it.Key} and value is {it.Value}");
            }
            Console.WriteLine("---New Way to Display SortedList---");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine($"The Key is: {sortedList.Keys[i]}, " +
                    $"Value is: {sortedList.Values[i]}");
            }

            Console.WriteLine("----------------SortedList-----------------");
            SortedList<int, string> st = new SortedList<int, string>()
            {
                { 5, "Five" },
                { 1, "One" },
                { 3, "Three" },
                { 4, "Four" },
                { 2, "Two" }
            };
            Console.WriteLine("---Before Modifying any element---");
            foreach (var it in st)
            {
                Console.WriteLine($"Key is: {it.Key} and value is {it.Value}");
            }

            //Access and modify in SortedList
            st[5] = "FIVE";  // make Five => FIVE (all chars are capital)
            Console.WriteLine("---After Modifying Elements---");
            foreach (var it in st)
            {
                Console.WriteLine($"Key is: {it.Key}, Value is: {it.Value}");
            }

            //INPORTANT!!!--- Creating SortedList of complex types-----!!!
            Console.WriteLine("!!!--- Creating SortedList of complex types-----!!!");
            SortedList<int, Employee> complexSortedList = new SortedList<int, Employee>();
            complexSortedList.Add(1, new Employee()
            {
                EmployeeNo = 1000,
                FullName = "Ahmed",
                Job = "Frontend",
                StartSalary = 4000,
                WorkingHoursPerWeek = 60,
                contract = Contract.Casual

            });
            //Parameterized Constructor
            complexSortedList.Add(2, new Employee(800, "Mostafa", "Backend", 7000, 80, Contract.PartTime));
            complexSortedList.Add(3, new Employee(801, "Shaaban", "Frontend", 6000, 80, Contract.FullTime));
            complexSortedList.Add(4, new Employee(802, "Ragab", "Fullstack", 9000, 80, Contract.Casual));
            complexSortedList.Add(5, new Employee(803, "Abdo", "Backend", 8000, 80, Contract.Freelance));

            foreach (var it in complexSortedList)
            {
                Console.WriteLine($"Key is: ({it.Key}) and value is: {it.Value}, " +
                    $"Employee Name is: {it.Value.FullName} and he is: {it.Value.Job}, " +
                    $"Start salary is: {it.Value.StartSalary}, " +
                    $"and he is working {it.Value.WorkingHoursPerWeek} per week, " +
                    $"and he works as {Contract.FullTime}");
            }

        }
    }
}