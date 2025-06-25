using System;

class StudentMethodsWithParams
{
    static void Main()
    {
        // Call Method1 and store returned message
        string info = GetStudentInfo(20);
        Console.WriteLine(info);

        // Call Method2 with student name
        ShowStudentName("Anusha");

        // Call Method3 with different types
        DisplayStudentID(2025);
        DisplayStudentID("STU_2025");
        DisplayStudentID(true);
    }

    /// <summary>
    /// Accepts age and returns formatted student info
    /// </summary>
    static string GetStudentInfo(int age)
    {
        string studentName = "Anusha";
        return string.Format("Student Name: {0}, Age: {1}", studentName, age);
    }

    /// <summary>
    /// Displays the name of the student
    /// </summary>
    static void ShowStudentName(string name)
    {
        Console.WriteLine($"Student name is: {name}");
    }

    /// <summary>
    /// Uses dynamic to accept different types of student IDs
    /// </summary>
    static void DisplayStudentID(dynamic id)
    {
        Console.WriteLine($"Student ID: {id}");
    }
}