using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Week1
{
    public class LinkedListExample
    {
        // LinkedList collection
        LinkedList<int> numbers = new LinkedList<int>();

        // ---------------- LINKED LIST EXAMPLE ----------------
        // Demonstrates adding and removing elements
        public void LinkedList()
        {
            // Adding elements
            numbers.AddLast(10);
            numbers.AddFirst(5);
            numbers.AddLast(15);

            // Find a node and insert before/after it
            var node = numbers.Find(10);
            numbers.AddBefore(node, 8);
            numbers.AddAfter(node, 12);

            Console.WriteLine("LinkedList elements:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            // Removing elements
            numbers.RemoveFirst();
            numbers.Remove(12);
            numbers.RemoveLast();

            Console.WriteLine("\nAfter removals:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
