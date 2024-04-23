using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Classes
{
    internal class Queue
    {
        public static void Go()
        {
            // Create a Queue of strings
            Queue<string> queue = new Queue<string>();

            // Enqueue elements to the Queue
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            // Print the Queue
            Console.WriteLine("Original Queue:");
            PrintQueue(queue);

            // Dequeue an element
            string dequeuedItem = queue.Dequeue();  // Dequeue() => remove front element
            Console.WriteLine("\nDequeued item: " + dequeuedItem);

            // Print the Queue after dequeuing
            Console.WriteLine("\nQueue after dequeue:");
            PrintQueue(queue);

            // Peek : Retrieve the front element without removing it
            string frontElement = queue.Peek();
            Console.WriteLine("\nFront element (peek): " + frontElement);

            // Print the Queue after peeking
            Console.WriteLine("\nQueue after peeking:");
            PrintQueue(queue);

            //Queue of complex Types
            Console.WriteLine("------Queue of complex Types------");
            Queue<Customer> complexQueue = new Queue<Customer>();
            complexQueue.Enqueue(new Customer()
            {
                custometId = 1000,
                customerName = "Mansour",
                arrivalTime = new TimeOnly(8, 30)
            });
            complexQueue.Enqueue(new Customer()
            {
                custometId = 1001,
                customerName = "Mostafa",
                arrivalTime = new TimeOnly(7, 40)
            });
            complexQueue.Enqueue(new Customer()
            {
                custometId = 1002,
                customerName = "Shehab",
                arrivalTime = new TimeOnly(7, 30)
            });
            complexQueue.Enqueue(new Customer()
            {
                custometId = 1003,
                customerName = "Hassan",
                arrivalTime = new TimeOnly(8, 50)
            });
            //parametrarized constructor
            complexQueue.Enqueue(new Customer(1004, "Ali", new TimeOnly(7,15)));

            foreach(Customer it in complexQueue)
            {
                Console.WriteLine($"List of current Customer| {complexQueue.Count} " +
                    $"Customer Id is: {it.custometId}, " +
                    $"Customer name is: {it.customerName}, " +
                    $"Customer has arrived At {it.arrivalTime} ");
            }
            Console.WriteLine("------");
            Console.WriteLine(complexQueue.Dequeue());
            Console.WriteLine(complexQueue.Dequeue().customerName);
            Console.WriteLine(complexQueue.Dequeue().custometId);

        }

        // Helper method to print the elements of the Queue
        static void PrintQueue(Queue<string> queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
