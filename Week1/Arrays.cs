using System;
using System.Collections.Generic;

public class Program
{
    // This is a dynamic list (resizable collection) used to store employees added at runtime.
    public List<string> employeesDynamic = new List<string>();


    // This is a stack  used to add items from the bottom to the top.
    Stack<int> stack = new Stack<int>();
    public Program()
    {
        Console.WriteLine("Please enter a number to add it to the stack");
        int input = Convert.ToInt32(Console.ReadLine());
        stack.Push(input);
        if (stack.Count > 0)
        {
            Console.WriteLine("You added the number: " + stack.Peek());
        }

    }
     
    // This is a fixed-size array initialized with 10 employee names.
    public string[] employees = {
        "John Stevenson",   // index 0
        "Jane Smith",       // index 1
        "Tim Wilson",       // index 2
        "Kate Stevenson",   // index 3
        "Kate Palmer",      // index 4
        "Tom Eastman",      // index 5
        "Laura Green",      // index 6
        "Mike Watson",      // index 7
        "Sally Black",      // index 8
        "Mark Ramsey"       // index 9
    };

    // Prints specific employees from the fixed array using their indices.
    public void PrintEmployees()
    {
        // employees[1] accesses the second element ("Jane Smith").
        Console.WriteLine("The first employee is " + employees[1]);

        // employees[7] accesses the eighth element ("Mike Watson").
        Console.WriteLine("The second employee is " + employees[7]);
    }

    // Prompts the user to add a new employee name into the dynamic list.
    public void AddEmployees()
    {
        Console.WriteLine("Enter a new employee name:");

        // Read a line from the console and add it to the List.
        // If the user presses Enter without typing, an empty string will be added.
        string input = Console.ReadLine();
        employeesDynamic.Add(input); // add the entered name to the list

        // After adding, the newly added employee will be at the end of the list.
        // For this simple example we print the first element at index 0,
        // which will reflect the first addition if the list was previously empty.
        if (employeesDynamic.Count > 0)
        {
            Console.WriteLine("You added the employee: " + employeesDynamic[0]);
        }
        else
        {
            Console.WriteLine("No employee was added.");
        }
    }

    // Entry point of the program.
    public static void Main(string[] args)
    {
        // Create an instance of Program to access instance members.
        var program = new Program();

        // Demonstrate reading from the fixed array.
        program.PrintEmployees();

        // Demonstrate adding to and reading from the dynamic list.
        program.AddEmployees();

        Program AskForNumber = new Program();
        // Wait for the user to press Enter before closing the console window.
        Console.ReadLine();
    }
}

