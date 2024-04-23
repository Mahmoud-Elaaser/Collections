using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Stack
    {
        public static void Go()
        {
            // Create a Stack of integers
            Stack<int> stack = new Stack<int>();

            // Push elements onto the Stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Print the Stack
            Console.WriteLine("Original Stack:");
            PrintStack(stack);

            // Removing and returning the element at the top of the Stack
            int poppedItem = stack.Pop();
            Console.WriteLine("\nPopped item: " + poppedItem);
            Console.WriteLine($"Top element is: {stack.Pop()}");

            // Print the Stack after popping
            Console.WriteLine("\nStack after popping:");
            PrintStack(stack);

            // Getting the element at the top of the Stack without removing it
            int topElement = stack.Peek();
            Console.WriteLine("\nTop element (peek): " + topElement);

            // Count of elements in the Stack
            int count = stack.Count;
            Console.WriteLine("Count: " + count);

            // Print the Stack after peeking
            Console.WriteLine("\nStack after peeking:");
            PrintStack(stack);

            //Stack of complex types
            Stack<Employee> complexStack = new Stack<Employee>();
            complexStack.Push(new Employee()
            {
                EmployeeNo = 1001,
                FullName = "Amir",
                Job = "Tester",
                StartSalary = 12000,
                contract = Contract.FullTime
            });
            complexStack.Push(new Employee()
            {
                EmployeeNo = 1002,
                FullName ="Mounir",
                Job="Frontend",
                StartSalary=6000,
                contract= Contract.Freelance
            });
            //Display Stack of complex types
            Console.WriteLine("------Display Stack of complex types------");
            foreach (Employee it in complexStack)
            {
                Console.WriteLine($"Fullname is: {it.FullName}\n" +
                    $"His Job is: {it.Job}\n" +
                    $"Starting salary is: {it.StartSalary}\n" +
                    $"he works as {Contract.Casual}");
            }


            stack.Clear();
        }

        // Helper method to print the elements of the Stack
        static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
