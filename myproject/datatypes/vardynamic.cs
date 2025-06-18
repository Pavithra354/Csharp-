using System;


class vardynamic
{
    static void Main()
    { 
        // Compile-Time Type Inference
        //The var keyword lets the compiler figure out the type based on the assigned value
        //It’s type-safe and checked at compile time.

        var name = "pavithra";
        Console.WriteLine(name.GetType());//system.string
        //name = 10;//if we reassign again it throws an error

        Console.WriteLine("name is" + name.ToUpper());

        int nameLength = name.Length;
        Console.WriteLine(nameLength);//6

        //dynamic------Run-time Inference
        dynamic bookName = "Wings of fire";
        dynamic bookAuthor = "Apj abdul kalam";
        dynamic NoOfPages = 120;
        Console.WriteLine($"bookname :" + bookName);
        Console.WriteLine($"bookAuthor :" + bookAuthor);
        Console.WriteLine($"No of pages are :" + NoOfPages);
        dynamic value = 20;
        Console.WriteLine(value + 5);
        Console.WriteLine(value.GetType());//system.int32
        value = "hello";
        Console.WriteLine(value.ToUpper());

        string input = "****welcome***";
        Console.WriteLine(input.Remove(1, 4));


        //lets take example of both var and dynamic
        var color = "red";
        int colors1 = color.Length;
        Console.WriteLine(colors1);


        dynamic redcolor = "red";
        int colors2 = redcolor.Length;
        Console.WriteLine(colors2);
        




    }
}
