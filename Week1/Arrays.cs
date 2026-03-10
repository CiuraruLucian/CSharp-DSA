using System;
using System.Collections.Generic;
public class Program
{
    // Write a program which creates an array with the 10 employees.
    // Display "Jane Smith" and "Mike Watson" by indexing the array appropriately
    // This is an array
    
    // This is an list
    public List<string> employeesDynamic = new List <string>();


    public string[] employees = { "John Stevenson", "Jane Smith", "Tim Wilson", "Kate Stevenson", "Kate Palmer", "Tom Eastman" , "Laura Green" , "Mike Watson", "Sally Black", "Mark Ramsey" };
    public void PrintEmployees()
    {
        Console.WriteLine("The first employee is " + employees[1]);
        Console.WriteLine("The second employee is " + employees[7]);
        
    }
    public void AddEmployees()
    {
        Console.WriteLine("Enter a new employee name:");
        employeesDynamic.Add(Console.ReadLine()); // to add an employee to the list
        Console.WriteLine("You added the employee: " + employeesDynamic[0]); // to print the employee added 
    }
   
    public static void Main(string[] args)
    {
        var program = new Program();
        program.PrintEmployees();
        program.AddEmployees();

        Console.ReadLine();
    }
}

