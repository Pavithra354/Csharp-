using System;
using System.Runtime.Remoting.Channels;


class stringspractice
{
    static void Main()
    {
        string firstName = "pavithra";
        string lastName = "Narala";
        string fullName = firstName + lastName;
        Console.WriteLine("My full name is" + fullName);

        //reading from console....
        Console.WriteLine("Please enter your password");
        string password = Console.ReadLine();
        Console.WriteLine("your password is" + password);
        //using interpolation
        int age = 25;
        Console.WriteLine($"My name is {fullName} and I am {age} years old.");

        //to print string with ""
        string schoolName = "\"Rainbow international school\"";
        Console.WriteLine("The school name is " + schoolName);


        string numberStrings = "One.\nTwo.\nThree";  // prints one ,two ,three line by line
        Console.WriteLine(numberStrings);

        string[] cities = { "hyderbad", "Visakapatanam", "Delhi" };
        Console.WriteLine(cities[0]); //hyderbad
        Console.WriteLine(cities[1]);//Visakapatanam.
        Console.WriteLine(cities.Length);//3
        foreach (string city in cities)
        {
            Console.WriteLine("The cities are :" + city);
        }

        Console.WriteLine(".......To print each character in a line with spaces............ ");
        string apartmentName = "saraswati nilayam";
        foreach (char appartment in apartmentName)
        {
            Console.WriteLine(appartment);
        }
        //one more example......
        string sentence = "Welcome to C# programming";
        string[] words = sentence.Split(' ');

        foreach (string word in words)
        {
            Console.WriteLine(word);//welcome in one line then to then c# then programming
        }

        //wants to print in reverse order
        string moviename = "dd returns";
        for (int i = moviename.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(moviename[i]);//prints along with space

        }
    }
}