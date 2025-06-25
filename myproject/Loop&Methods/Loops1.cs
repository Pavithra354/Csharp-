using System;

class Loops1
{
    static void Main()
    {
        // WHILE LOOP - adding fruits one by one
        int fruitsCollected = 0;
        Console.WriteLine($"Fruits before collection: {fruitsCollected}");

        while (fruitsCollected < 5)
        {
            fruitsCollected++;
        }

        Console.WriteLine($"Fruits after collection: {fruitsCollected}");

        Console.WriteLine("----------------------------------------------------");

        // DO-WHILE LOOP - add only red apples to count
        string[] fruitBox = { "Apple", "Banana", "Apple", "Orange", "Apple" };
        int i = 0;
        int appleCount = 0;

        do
        {
            if (fruitBox[i] == "Apple")
            {
                appleCount++;
                Console.WriteLine($"Found Apple. Total Apples: {appleCount}");
            }
            i++;
        } while (i < fruitBox.Length);

        Console.WriteLine("----------------------------------------------------");

        // FOREACH LOOP - display all fruits in basket
        foreach (string fruit in fruitBox)
        {
            Console.WriteLine($"Fruit in basket: {fruit}");
        }

        Console.WriteLine("----------------------------------------------------");

        // FOR LOOP - count fruit crates (multiples of 2 up to 16)
        for (int crate = 2; crate <= 16; crate *= 2)
        {
            Console.WriteLine($"Fruit crate number: {crate}");
        }
    }
}
