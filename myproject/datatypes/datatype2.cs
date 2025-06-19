using System;

class datatype2
{
    static void Main()
    {
        Console.WriteLine(".........To find the min and maxium values........");
        Console.WriteLine($"Byte => Minimum Range:{byte.MinValue} and Maximum Range:{byte.MaxValue}");
        Console.WriteLine($"Integer => Minimum Range:{int.MinValue} and Maximum Range:{int.MaxValue}");
        Console.WriteLine($"Float => Minimum Range:{float.MinValue} and Maximum Range:{float.MaxValue}");
        Console.WriteLine($"Long => Minimum Range:{long.MinValue} and Maximum Range:{long.MaxValue}");
        Console.WriteLine($"Double => Minimum Range:{double.MinValue} and Maximum Range:{double.MaxValue}");


        Console.WriteLine("...........to Get the size...............");
        Console.WriteLine($"Size of Byte: {sizeof(byte)}");
        Console.WriteLine($"Size of Integer: {sizeof(int)}");
        Console.WriteLine($"Size of Character: {sizeof(char)}");
        Console.WriteLine($"Size of Float: {sizeof(float)}");
        Console.WriteLine($"Size of Long: {sizeof(long)}");
        Console.WriteLine($"Size of Double: {sizeof(double)}");
        Console.WriteLine($"Size of Bool: {sizeof(bool)}");



        Console.WriteLine("...........Char type...............");
        char ch = 'B';
        Console.WriteLine($"Char: {ch}");
        Console.WriteLine($"Char Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
        Console.WriteLine($"Char Size: {sizeof(char)} Byte");


        Console.WriteLine("**************String type*********************");
        string str = "pavithra";
        Console.WriteLine("string length  is" + str.Length);
        Console.WriteLine($"str Value: {str}");
        Console.WriteLine("***readLine waits for the user to enter the name **********");
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");


        Console.WriteLine("**************maximum digits ********************");
        //testing 
        float a = 1.7898638087f; //7 digits Maximum
        double b = 1.789863808300294; //15 digits Maximum
        decimal c = 1.78986380830029492956829m; //29 digits Maximum
        Console.WriteLine("float value is " + a);
        Console.WriteLine("Double value is " + b);
        Console.WriteLine("Decimal  value is " + c);

        Console.WriteLine("**************lets check the performance now*********************");



        //Console.WriteLine("Checking the performance");
        //  Stopwatch stopwatch1 = new Stopwatch();
        //stopwatch1.Start();
        //for (int i = 0; i < 1000000; i++)
        //{
        //    short s1 = 100;
        //    short s2 = 100;
        //    short s3 = 100;
        //}
        //stopwatch1.Stop();
        //Console.WriteLine($"short took : {stopwatch1.ElapsedMilliseconds} MS");
        //Stopwatch stopwatch2= new Stopwatch();
        //stopwatch2.Start();
        //for (int i = 0; i < 1000000; i++)
        //{
        //    decimal d1 = 100;
        //    decimal d2 = 100;
        //    decimal d3 = 100;
        //}
        //stopwatch1.Stop();
        //Console.WriteLine($"Decimal took : {stopwatch2.ElapsedMilliseconds} MS");
        //Console.ReadKey();
        //here short took 1msec and decimal took 3 msec.






    }
}