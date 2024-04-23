using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections.Classes
{
    internal class HashSet
    {
        public static void Go()
        {
            // Create a HashSet of integers
            HashSet<int> numbers = new HashSet<int>();

            // Add elements to the HashSet
            numbers.Add(5);
            numbers.Add(10);     // output => (5, 10, 15) No duplication
            numbers.Add(10);
            numbers.Add(15);

            // Print the HashSet
            Console.WriteLine("Original HashSet:");
            PrintHashSet(numbers);

            // Check if an element exists in the HashSet
            bool containsElement = numbers.Contains(10);
            Console.WriteLine("\nDoes the HashSet contain 10? " + containsElement);

            // Add a new element
            numbers.Add(20);

            // Print the HashSet after addition
            Console.WriteLine("\nHashSet after addition:");
            PrintHashSet(numbers);

            // Remove an element
            numbers.Remove(10);

            // Print the HashSet after removal
            Console.WriteLine("\nHashSet after removal:");
            PrintHashSet(numbers);

            //Sorted set
            Console.WriteLine("------Sorted Set------");
            SortedSet<string> languages = new SortedSet<string>();
            languages.Add("English");
            languages.Add("Spanish");
            languages.Add("Jermany");
            languages.Add("Italy");
            languages.Add("Arabic");
            Console.WriteLine("Languages are: ");
            foreach (string it in languages)
            {
                Console.WriteLine($"{it}");
            }

            Console.WriteLine("---");
            var sortedSet = new SortedSet<int>() { 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            foreach (int it in sortedSet)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine("\n---Maximum and Minimum numbers in Sorted Set---");
            Console.WriteLine("Maximum number in Sorted Set is: " + sortedSet.Max);
            Console.WriteLine("Minimum number in Sorted Set is: " + sortedSet.Min);

            //subset
            Console.WriteLine("---SubSet---");
            var subSet = sortedSet.GetViewBetween(10, 70); // 10 20 .... 70
            subSet.Add(15);  // LOOK:) 15 is added so: 10 15 20 .. 70
            foreach (int it in subSet)
            {
                Console.Write(it + " ");
            }
            // Intersection between two Sets
            Console.WriteLine("\n------Intersection Between Two sets------");
            var subset2 = new SortedSet<int>() { 50, 60, 70, 80, 90, 100, 110, 120, 130 };
            var intersectedSets = subSet.Intersect(subset2);
            foreach (int it in intersectedSets)
            {
                Console.Write(it + " "); // 50 60 70
            }

            // Difference
            Console.WriteLine("\n---Difference between two sets---");
            subset2.ExceptWith(subSet);
            Console.WriteLine("Difference Elements are: ");
            foreach (var it in subset2)
            {
                Console.Write($"{it} ");  // 80 90 100 110 120 130
            }
            Console.WriteLine();

            //Union
            Console.WriteLine("---Union---");
            var unionSet = subSet.Union(subset2);  // No duplication
            Console.WriteLine("Union Elements are: ");
            foreach (var it in unionSet)
            {
                Console.Write($"{it} "); // 10 15 20 30 40 50 60 70 80 90 100 110 120 130
            }
            Console.WriteLine();


        }

        // Helper method to print the elements of the HashSet
        static void PrintHashSet(HashSet<int> hashSet)
        {
            foreach (var number in hashSet)
            {
                Console.WriteLine(number);
            }
        }
    }
}
