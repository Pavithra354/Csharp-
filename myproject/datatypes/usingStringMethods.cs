using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Web;




class usingStringMethods
{
    static void Main()
    {
        string area = "LB NAGAR";
        int area1 = area.Length;//here length is a property returns integer type 
        Console.WriteLine(area1);//7
        //using indexOf
        string shoppingmallName = "SOUTH iNDIA SHOPPING MALL";
        int mallName = shoppingmallName.IndexOf("N");//returns int 
        Console.WriteLine($"the index of :{mallName}");//if s its shows 0.n means o/p-8

        //using contains
        string place = "hyderbad is most beautiful,place in the world";
        bool desc = place.Contains("beautiful");//return bool
        Console.WriteLine("is beautiful present in my string" + desc);

        //using trim
        string trim1 = place.Trim(',');
        Console.WriteLine(" the orginal  sentence is" + place);
        Console.WriteLine("we are triming the sentence" + trim1);

        string app = "$$$$$$$$$$$$$Book my show***************";
        string updated = app.Trim('*');
        Console.WriteLine("The updated trim is " + updated);//removed *
        Console.WriteLine("we are using trim start" + app.TrimStart('$'));//remove $
        Console.WriteLine("we are using trim end" + app.TrimEnd('*'));//remove*

        //we are using format
        var item = "sofa";
        var quantity = 5;
        string receipt = string.Format("You purcahsed {0} items for {1}", item, quantity);
        Console.WriteLine(receipt);
        //one more example using format
        var temperature = 40;
        string weather = string.Format("the temperature is {0}c", temperature);
        Console.WriteLine(weather);//the temperature is 40c

        //we are using padleft here
        string empName = "aravind";
        Console.WriteLine("our building name is:" + empName.PadLeft(10));//it allocates space before and checks the string
        Console.WriteLine("our building name is:" + empName.PadLeft(10, '*'));//***aravind

        //as table format........
        Console.WriteLine("FRUITS".PadRight(15) + "Price".PadLeft(10));
        Console.WriteLine("Apple".PadRight(15) + "₹25".PadLeft(10));
        Console.WriteLine("Banana".PadRight(15) + "₹10".PadLeft(10));

        //to get the present time.

        string timestamp = DateTime.Now.ToString("mm:hh:ss");
        Console.WriteLine($"Todays date is:[{timestamp.PadLeft(10)}]");


        //to get the date
        string presentDate = DateTime.Today.ToString("dd:MM:yy");
        Console.WriteLine($"Todays date is:[{presentDate.PadLeft(10)}]");

        int[] evenNumbers = { 2, 4, 6, 8, 10 };
        foreach (int Numbers in evenNumbers)
        {
            Console.WriteLine("the even numbers are :" + Numbers.ToString().PadLeft(10));//2,4,6,8,10 IN A LINE
        }

        //USING SUBSTRING

        string story = "little red ridding hood";
        Console.WriteLine("we are using substring here:   " + story.Substring(1, 6));//ittle
        string replacing = story.Replace("red", "blue");
        Console.WriteLine("we are usingreplacing  here:" + replacing);//change to blue

        //is pallindrome
        Console.WriteLine("please enter a name");
        string input = Console.ReadLine();
        string reverse = new string(input.Reverse().ToArray());
        if (input == reverse)
        {
            Console.WriteLine("the string is pallindrome");
        }
        else
        {
            Console.WriteLine("its not a pallindrome");
        }

        //to find vowels
        Console.WriteLine("please enter any thing to check ");
        string text = Console.ReadLine();
        string vowels = "AEIOUaeiou";
        string found = "";
        foreach (char c in text)
        {
            if (vowels.Contains(c) && !found.Contains(c))
            {
                found += c;
            }
        }
        Console.WriteLine("vowels found" + found);



    }


}

