using System;

class Conditionalstatements
{
    static void Main()
    {
        string[] students = { "Pavithra", "neha", "sai", "srikar", "srilu" };
        int[] marks = { 85, 45, 70, 30, 95 };

        Console.WriteLine("Student Performance Report:");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine("\nName: " + students[i]);
            EvaluateMarks(marks[i]);
        }

        GradeSwitch();
        AgeCategory();
        PassOrFail();
    }

    static void EvaluateMarks(int mark)
    {
        if (mark >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (mark >= 75)
        {
            Console.WriteLine("Grade: B");
        }
        else if (mark >= 50)
        {
            Console.WriteLine("Grade: C");
        }
        else if (mark >= 35)
        {
            Console.WriteLine("Grade: D (Needs Improvement)");
        }
        else
        {
            Console.WriteLine("Grade: F (Fail)");
        }
    }

    static void GradeSwitch()
    {
        Console.WriteLine("\nEnter your grade (A, B, C, D, F):");
        string grade = Console.ReadLine().ToUpper();

        switch (grade)
        {
            case "A":
                Console.WriteLine("Excellent Performance");
                break;
            case "B":
                Console.WriteLine("Good Job");
                break;
            case "C":
                Console.WriteLine("Average Work");
                break;
            case "D":
                Console.WriteLine("Try Harder");
                break;
            case "F":
                Console.WriteLine("Failed. Better luck next time");
                break;
            default:
                Console.WriteLine("Invalid Grade Entered");
                break;
        }
    }

    static void AgeCategory()
    {
        Console.WriteLine("\nEnter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
            Console.WriteLine("Too young for school.");
        else if (age >= 5 && age <= 17)
            Console.WriteLine("School student.");
        else if (age >= 18 && age <= 25)
            Console.WriteLine("College student.");
        else
            Console.WriteLine("Not a student age group.");
    }

    static void PassOrFail()
    {
        Console.WriteLine("\nEnter marks to check pass/fail:");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 35)
        {
            Console.WriteLine("You passed the exam.");
        }
        else
        {
            Console.WriteLine("You failed the exam.");
        }
    }
}