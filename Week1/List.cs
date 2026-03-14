using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Week1
{
    internal class ListExample
    {
        // Dynamic list (resizable) for employees added at runtime
        public List<string> employeesDynamic = new List<string>();

        // ---------------- LIST EXAMPLE ----------------
        // Rewrite your exercise 1.1 code to use a list rather than an array.
        public void AddEmployees()
        {
            Console.WriteLine("List exercise: ");

            // Adding members to the list 

            employeesDynamic.Add("John Stevenson");
            employeesDynamic.Add("Jane Smith");
            employeesDynamic.Add("Tim Wilson");
            employeesDynamic.Add("Kate Stevenson");
            employeesDynamic.Add("Kate Palmer");
            employeesDynamic.Add("Tom Eastman");
            employeesDynamic.Add("Laura Green");
            employeesDynamic.Add("Mike Watson");
            employeesDynamic.Add("Sally Black");
            employeesDynamic.Add("Mark Ramsey");
           
            Console.WriteLine("The employee who has the index 1 is: " + employeesDynamic[1]);
            Console.WriteLine("The employee who has the index 7 is: " + employeesDynamic[7]);




        }
    }
}
