using System;

class TypeConversions
{
    static void Main()
    {
        // Implicit conversion: int to float
        int age = 25;
        float ageInFloat = age;
        Console.WriteLine("Implicit conversion (int to float): " + ageInFloat); // 25

        // Explicit conversion: double to int
        double pi = 3.14159;
        int roundedPi = (int)pi;
        Console.WriteLine("Explicit conversion (double to int): " + roundedPi); // 3

        // Convert string to double using Convert
        string priceString = "49.99";
        double price = Convert.ToDouble(priceString);
        Console.WriteLine("String to double using Convert: " + price); // 49.99

        // Convert string to bool using bool.Parse
        string isActiveString = "true";
        bool isActive = bool.Parse(isActiveString);
        Console.WriteLine("String to bool using Parse: " + isActive); // true

        // Convert bool to string
        string activeStatus = isActive.ToString();
        Console.WriteLine("Bool to string using ToString(): " + activeStatus); // "True"

        // Convert int to char
        int ascii = 65;
        char letter = (char)ascii;
        Console.WriteLine("Int to char: " + letter); // A

        // Convert char to int
        char ch = 'Z';
        int asciiValue = (int)ch;
        Console.WriteLine("Char to int (ASCII): " + asciiValue); // 90

        // Nullable string to int using Convert
        string nullValue = null;
        int convertedNull = Convert.ToInt32(nullValue); // returns 0
        Console.WriteLine("Null string to int using Convert: " + convertedNull);

        // Unsafe: using int.Parse on null or non-numeric string
        string invalidNumber = "abc";
        try
        {
            int wrong = int.Parse(invalidNumber); // throws FormatException
            Console.WriteLine("Parsed value: " + wrong);
        }
        catch (FormatException)
        {
            Console.WriteLine("Cannot parse 'abc' to int");
        }

        // Converting string to DateTime
        string dob = "2003-07-27";
        DateTime birthDate = DateTime.Parse(dob);
        Console.WriteLine("Date of Birth: " + birthDate.ToShortDateString());

        // Getting string from DateTime
        string formattedDate = birthDate.ToString("yyyy/MM/dd");
        Console.WriteLine("Formatted Date: " + formattedDate); // "2003/07/27"
    }
}