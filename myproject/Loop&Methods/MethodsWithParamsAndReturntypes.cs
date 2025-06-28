using System;

//step4 methods completely we will work on the methods

//Access Modifiers

//Classes

//step1

/// <summary>

/// </summary>
class MethodsWithParamsAndReturntypes
{
    static void Main()
    {
        string studentDetails = getStudentDetails(5);

        printStudentNameById(5);

        string[] studentNames = getStudentNames();

        string[] otherStudents = { "Anil", "Sunil" };

        int length = getStudentNamesLengthByArray(otherStudents);

        Console.WriteLine($"Students Length: {length}");

        int[] marks = { 60, 75 };
        int[] updatedMarks = getUpdatedMarks(marks);

        foreach (int mark in updatedMarks)
        {
            Console.WriteLine(mark);
        }

        string[] names = { "Riya", "Anu" };
        int[] namesLength = getStudentNamesLength(names);

        foreach (int len in namesLength)
        {
            Console.WriteLine(len);
        }
    }

    /// <summary>
    /// Here I am updating each mark by adding 5
    /// </summary>
    /// <param name="marks"></param>
    /// <returns></returns>
    static int[] getUpdatedMarks(int[] marks)
    {
        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = marks[i] + 5;
        }
        return marks;
    }

    static int[] getStudentNamesLength(string[] names)
    {
        int[] lengths = new int[names.Length];

        for (int i = 0; i < names.Length; i++)
        {
            lengths[i] = names[i].Length;
        }
        return lengths;
    }

    /// <summary>
    /// Get student details by ID
    /// </summary>
    static string getStudentDetails(int id)
    {
        string studentDetails = $"Student Name is Rahul and his ID is {id}";
        return studentDetails;
    }

    static int getStudentAgeByName(string name)
    {
        return 15; // fixed value for example
    }

    static void printStudentNameById(int id)
    {
        Console.WriteLine($"Student Name is Rahul");
    }

    static void PrintStudentDetailsByNameAndAge(string name, int age)
    {
        Console.WriteLine($"Name is {name} and Age is {age}");
    }

    static string[] getStudentNames()
    {
        string[] names = { "Rahul", "Neha" };
        return names;
    }

    static int getStudentNamesLengthByArray(string[] names)
    {
        int length = names.Length;
        return length;
    }
}
