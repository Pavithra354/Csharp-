using System;
using System.Linq.Expressions;
class task1
{
    static void Main()
    {
        //3.Prepare the String Array 
        string[] employees = { "John", "Robert", "Chandra", "Peter" };
       // static void PrepareEmployeeArray()
      {
            //Console.WriteLine("--- Task 1: Prepare String Array ---");
           // string[] employees = { "John", "Robert", "Chandra", "Peter" };
            Console.WriteLine("Employees: " + string.Join(", ", employees));
       }
        //4.Get the Third Employee from the Array
        string thirdEmployee = employees[2];
        //5.Check weather Second and Third employee Equals or not 
        bool areEqual = employees[1] == employees[2];
        //6.Check the employee whose name starts with “J” from the Array
        foreach (string emp in employees)
        {
            if (emp.StartsWith("J"))
                Console.WriteLine(emp);
        }
        //7.Convert Employees List into single String
        string employeeString = string.Join(", ", employees);
        //8.Replace the “Robert” with “Peter” in String
        string updatedString = employeeString.Replace("Robert", "Peter");
        //9.Get the Employee whose name length is more that 4 charcters from the array
        foreach (string emp in employees)
        {
            if (emp.Length > 4)
                Console.WriteLine(emp);
        }
        //10.Diff b / w for and foreach ? Explain with example
        // for loop
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i]);
        }

        // foreach loop
        foreach (string emp in employees)
        {
            Console.WriteLine(emp);
        }
        //11.Explain me what is the importance of the Looping system. ? Explain with Example
        //Automate repetitive tasks.
        //Example: Display all employees without writing multiple Console.WriteLine
        //string[] employees = { "John", "Robert", "Chandra", "Peter" };

        foreach (string emp in employees)
        {
            Console.WriteLine(emp);
        }
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i]);
        }
        //12.What are the floating data types ? EXample
        float a = 1.2f;
        double b = 2.5;
        decimal c = 3.5m;
        //13. Logical operators are used to combine two or more conditions(expressions) and return true or false.
        //They help you make decisions in your program.
       // static void LogicalOperatorsExample()
       // {
           // Console.WriteLine("\n--- Task: Logical Operators Example ---");

           int d = 5;
            int e = 10;

            // AND operator
            bool andResult = (d > 0) && (e > 0);
            Console.WriteLine($"AND: (d > 0) && (e > 0) = {andResult}");

            // OR operator
            bool orResult = (d> 0) || (e < 0);
            Console.WriteLine($"OR: (d > 0) || (e < 0) = {orResult}");

            // NOT operator
            bool notResult = !(d > e);
            Console.WriteLine($"NOT: !(d > e) = {notResult}");
      //  }
        //14.What is the nullable types? Example
       // static void NullableTypesExample()
        {
            Console.WriteLine("\n--- Task 14: Nullable Types Example ---");

            int? age = null; // age is unknown
            Console.WriteLine("Nullable int age: " + age);

            age = 25; // later, we assign a value
            Console.WriteLine("After assigning: " + age);
        }
        //15.What is implicit conversation type ? Example
       // static void ImplicitConversionExample()
        {
            Console.WriteLine("\n--- Task 15: Implicit Conversion Example ---");

            int num = 100;           // smaller type
            float floatNum = num;    // implicit conversion: int -> float

            Console.WriteLine($"Int: {num} -> Float: {floatNum}");
        }
    }
}