using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Week1
{
    public class StackExample
    {
        // Stack collection (LIFO – Last In First Out)
        Stack<int> stack = new Stack<int>();


        // ---------------- STACK EXAMPLE ----------------
        // Asks the user for a number and pushes it onto the stack
        public void Stack()
        {
            Console.WriteLine("Please enter a number to add to the stack:");

            int input = Convert.ToInt32(Console.ReadLine());

            stack.Push(input); // add number to top of stack

            if (stack.Count > 0)
            {
                // Peek shows the top item without removing it
                Console.WriteLine("You added the number: " + stack.Peek());
            }
        }
    }
}
