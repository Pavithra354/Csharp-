using System;




class datatype1
{
    static void Main(string[] args)
    {
        sbyte level = 12;
        Console.WriteLine(level);//output-12 and  range -127 to 128 size=8bits.



        short value = -1109;
        Console.WriteLine(value);//o/p:1109 and range :: -32,768 to 32,767 size:16bits

        int marks = 100;
        Console.WriteLine(marks);//o/p:100 Range: -231 to 231 - 1 Size: 32 bits

        long range = -1234456666L;
        Console.WriteLine(range);//o/p:-1234456666 Range: -263 to 263-1 size:64 bits

        //unsigned Integrals

        byte age = 15;
        Console.WriteLine(age);//Range: 0 to 255.

        ushort value1 = 42019;
        Console.WriteLine(value1);//Range:0 to 65,535

        uint totalScore = 1151092;
        Console.WriteLine(totalScore);// 0 to 232-1

        ulong range1 = 17091821871L;
        Console.WriteLine(range1);//0 to 264-1

        float number = 43.27F;
        Console.WriteLine(number);//1.5 × 10−45 to 3.4 × 1038

        double value2 = -11092.53D;
        Console.WriteLine(value2);//5.0 × 10−324 to 1.7 × 10308

        char ch1 = '\u0042';
        char ch2 = 'x';
        Console.WriteLine(ch1);//b-unicode value
        Console.WriteLine(ch2);//x

        decimal bankBalance = 5005.25m;//[M at the end represent the value is of decimal type]
        Console.WriteLine(bankBalance);

        // boolean data type
        bool b = true;

        if (b == true)
            Console.WriteLine("Hi pavithra");

        // To prevent the screen from running and closing quickly 
        Console.ReadKey();





    }
}