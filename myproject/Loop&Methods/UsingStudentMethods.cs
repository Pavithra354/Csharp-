using System;

class StudentMethods
{
    static void Main()
    {
        string studentName = GetStudentName();   // Returns a string
        Console.WriteLine("Student Name: " + studentName);

        int studentMarks = GetStudentMarks();    // Returns an int
        Console.WriteLine("Marks Scored: " + studentMarks);

        PrintStudentDetails();                   // Just prints info (void)
    }

    static string GetStudentName()
    {
        string name = "Pavithra";
        return name;
    }

    static int GetStudentMarks()
    {
        int marks = 92;
        return marks;
    }

    static void PrintStudentDetails()
    {
        Console.WriteLine("Pavithra is a top-performing student in Computer Science with 92 marks.");
    }
}