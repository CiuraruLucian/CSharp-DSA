# C# Data Structures and Algorithms (DSA)

## Overview
This repository contains exercises and practice projects for **Data Structures and Algorithms** in C#.  
The goal is to implement, explore, and understand common **data structures, algorithms, and problem-solving techniques** using C#.

This is a **work-in-progress repository** — it will be continuously updated with new exercises, solutions, and topics.

---

## Topics Covered (so far)
- **Arrays and Lists** – fixed arrays, dynamic lists, indexing, adding elements
- **Basic Algorithms** – simple loops, conditional logic, and iterative calculations

> Future topics may include:  
> - Stacks, Queues, Linked Lists  
> - Dictionaries and HashSets  
> - Recursion and Sorting Algorithms  
> - Search algorithms (linear, binary)  
> - Trees and Graphs  

---

## Example Exercise
**Employees Array & List Exercise**  

```csharp
string[] employees = { "John Stevenson", "Jane Smith", "Tim Wilson", "Kate Stevenson", "Kate Palmer", "Tom Eastman" , "Laura Green" , "Mike Watson", "Sally Black", "Mark Ramsey" };
List<string> employeesDynamic = new List<string>();

Console.WriteLine("The first employee is " + employees[1]);
Console.WriteLine("The second employee is " + employees[7]);

employeesDynamic.Add("Lucian Ciuraru");
Console.WriteLine("You added the employee: " + employeesDynamic[0]);

## How to Run
**Prerequisites**

.NET SDK

Visual Studio or VS Code (with C# extension)

## Steps

**Clone the repository:**

git clone https://github.com/CiuraruLucian/CSharp-DSA.git

**Navigate to the folder:**

cd CSharp-DSA

**Build and run the application:**

dotnet run
