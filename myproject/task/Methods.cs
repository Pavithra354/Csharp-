using System;

class Methods
{
    static void Main()
    {
        Console.WriteLine("=== TASKS 16 to 19 ===\n");

        ExampleAddNumbers();
        CheckNumberSign(-5);
        PrintDayOfWeek(3);
        CombinedConditionMethod(2);
    }

    //  16: Method with params & return type
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void ExampleAddNumbers()
    {
        Console.WriteLine("--- Task 16: Method with Params & Return Type ---");
        int sum = AddNumbers(5, 7);
        Console.WriteLine($"5 + 7 = {sum}");
    }

    //  17: Method with if-elseif-else conditions
    static void CheckNumberSign(int num)
    {
        Console.WriteLine("\n--- Task 17: Method with If-ElseIf-Else ---");

        if (num > 0)
        {
            Console.WriteLine($"{num} is Positive");
        }
        else if (num < 0)
        {
            Console.WriteLine($"{num} is Negative");
        }
        else
        {
            Console.WriteLine($"{num} is Zero");
        }
    }

    //  18: Method with switch-case
    static void PrintDayOfWeek(int day)
    {
        Console.WriteLine("\n--- Task 18: Method with Switch-Case ---");

        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            default: Console.WriteLine("Other Day"); break;
        }
    }

    // 19: Method with if-elseif-else + switch-case
    static void CombinedConditionMethod(int num)
    {
        Console.WriteLine("\n--- Task 19: Method with If-ElseIf-Else + Switch-Case ---");

        if (num > 0)
        {
            switch (num)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                default: Console.WriteLine("Other positive number"); break;
            }
        }
        else if (num < 0)
        {
            Console.WriteLine("Negative number");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}
