using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Week1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayExample arrayExample = new ArrayExample();
            arrayExample.PrintEmployees();

            ListExample listExample = new ListExample();
            listExample.AddEmployees();

            StackExample stackExample = new StackExample();
            stackExample.Stack();

            LinkedListExample linkedListExample = new LinkedListExample();
            linkedListExample.LinkedList();

            Console.ReadLine();
        }
    }
}

