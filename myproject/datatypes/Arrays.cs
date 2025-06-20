using System;

class Arrays
{
    static void Main()
    {
        // Float array
        float[] prices = { 12.5f, 99.99f, 45.6f, 5.25f };
        Console.WriteLine("Float array elements:");
        foreach (float price in prices)
        {
            Console.WriteLine("₹" + price);
        }

        // Char array
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
        Console.WriteLine("\nVowel characters:");
        foreach (char v in vowels)
        {
            Console.WriteLine(v);
        }

        // Boolean array
        bool[] flags = { true, false, true, false };
        Console.WriteLine("\nBoolean array:");
        foreach (bool b in flags)
        {
            Console.WriteLine(b);
        }

        // Jagged Array
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6 };

        Console.WriteLine("\nJagged array elements:");
        for (int i = 0; i < jagged.Length; i++)
        {
            foreach (int val in jagged[i])
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }

        // Sorting and Reversing array
        int[] marks = { 85, 42, 96, 74, 58 };
        Console.WriteLine("\nOriginal marks:");
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }

        Array.Sort(marks);
        Console.WriteLine("\nSorted marks:");
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }

        Array.Reverse(marks);
        Console.WriteLine("\nReversed marks:");
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }

        // String Array
        string[] names = { "Pavithra", "Anil", "Ravi", "Sneha" };
        Console.WriteLine("\nNames in string array:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // String split to array
        string animals = "Dog,Cat,Cow,Elephant,Lion";
        string[] animalArray = animals.Split(',');
        Console.WriteLine("\nAnimals list from string:");
        foreach (string animal in animalArray)
        {
            Console.WriteLine(animal);
        }

        // Using var with string array
        var colors = new[] { "Red", "Green", "Blue", "Yellow" };
        Console.WriteLine("\nColors:");
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        // String as character array (foreach on string)
        string message = "HELLO";
        Console.WriteLine("\nCharacters in string:");
        foreach (char ch in message)
        {
            Console.WriteLine(ch);
        }
    }
}
