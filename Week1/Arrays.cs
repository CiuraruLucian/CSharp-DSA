using System;
using System.Collections.Generic;

public class ArrayExample
{
    // Fixed-size array containing predefined employee names
    public string[] employees =
    {
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

    // ---------------- ARRAY EXAMPLE ----------------
    // Write a program which creates an array with the 10 employees mentioned in Exercise 1
    // Display "Jane Smith" and "Mike Watson" by indexing the array appropriately.
    public void PrintEmployees()
    {
        Console.WriteLine("The first employee is " + employees[1]);
        Console.WriteLine("The second employee is " + employees[7]);
    }

}
