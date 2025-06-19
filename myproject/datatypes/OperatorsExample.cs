using System;

class OperatorsExample
{
    static void Main()
    {
        // Arithmetic Operators
        int a = 10, b = 5;
        Console.WriteLine("Addition: " + (a + b));      // 15
        Console.WriteLine("Subtraction: " + (a - b));   // 5
        Console.WriteLine("Multiplication: " + (a * b));// 50
        Console.WriteLine("Division: " + (a / b));      // 2
        Console.WriteLine("Modulo: " + (a % b));        // 0

        // Assignment Operators
        int x = 10;
        x += 5;  // x = x + 5
        Console.WriteLine("After += : " + x);           // 15
        x -= 3;  // x = x - 3
        Console.WriteLine("After -= : " + x);           // 12

        // Comparison (Relational) Operators
        int p = 8, q = 10;
        Console.WriteLine("p == q: " + (p == q));       // false
        Console.WriteLine("p != q: " + (p != q));       // true
        Console.WriteLine("p > q: " + (p > q));         // false
        Console.WriteLine("p < q: " + (p < q));         // true
        Console.WriteLine("p >= 8: " + (p >= 8));       // true
        Console.WriteLine("q <= 10: " + (q <= 10));     // true

        // Logical Operators
        bool cond1 = true;
        bool cond2 = false;
        Console.WriteLine("cond1 && cond2: " + (cond1 && cond2)); // false
        Console.WriteLine("cond1 || cond2: " + (cond1 || cond2)); // true
        Console.WriteLine("!cond1: " + (!cond1));                 // false

        // Ternary Operator
        int marks = 45;
        string result = (marks >= 35) ? "Pass" : "Fail";
        Console.WriteLine("Result: " + result);         // Pass

        // Null-Coalescing Operator
        string name = null;
        string finalName = name ?? "Guest";
        Console.WriteLine("Name: " + finalName);        // Guest
    }
}