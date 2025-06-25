using System;

class MethodsWithParamsAndReturn
{
    static void Main()
    {
        string studentInfo = GetStudentDetails(1001);
        Console.WriteLine(studentInfo);

        int marks = GetStudentMarksByName("Pavithra");
        Console.WriteLine($"Marks: {marks}");
    }

    /// <summary>
    /// Returns student details based on ID
    /// </summary>
    static string GetStudentDetails(int studentId)
    {
        string studentDetails = $"Student Name is Pavithra and ID is {studentId}";
        return studentDetails;
    }

    /// <summary>
    /// Returns marks based on student name
    /// </summary>
    static int GetStudentMarksByName(string name)
    {
        int marks = 0;

        if (name == "Pavithra")
        {
            marks = 95;
        }
        else if (name == "Anusha")
        {
            marks = 88;
        }
        else
        {
            marks = 70; // default
        }

        return marks;
    }
}
