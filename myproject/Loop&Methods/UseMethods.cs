using System;

class UseMethods
{
    /// <summary>
    /// Main entry point where we call different methods.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Program Started...\n");

        WelcomeMessage();
        PrintStudentName("Pavithra");
        int result = Square(7);
        Console.WriteLine($"Square of 7 is: {result}");

        Console.WriteLine("\nCalling All Tasks Together:");
        PerformAllTasks();
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Methods Example!");
    }

    static void PrintStudentName(string name)
    {
        Console.WriteLine($"Student Name is: {name}");
    }

    static int Square(int number)
    {
        return number * number;
    }

    static void PerformAllTasks()
    {
        WelcomeMessage();
        PrintStudentName("Anusha");
        Console.WriteLine($"Square of 5 is: {Square(5)}");
    }
}
