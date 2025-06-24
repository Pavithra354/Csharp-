using System;

class Conditionalstatements1
{
    static int balance = 1000; // Starting balance

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Simple ATM ---");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowBalance();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    Withdraw();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the ATM.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }

    static void ShowBalance()
    {
        Console.WriteLine($"Your current balance is: ₹{balance}");
    }

    static void Deposit()
    {
        Console.Write("Enter amount to deposit: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        balance += amount;
        Console.WriteLine($"Deposited ₹{amount}. New Balance: ₹{balance}");

        // Ternary operator to display a quick status
        string status = amount >= 500 ? "Big deposit!" : "Small deposit!";
        Console.WriteLine(status);
    }

    static void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        if (amount <= balance && amount > 0)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn ₹{amount}. Remaining Balance: ₹{balance}");

            // Ternary operator for quick note
            Console.WriteLine(amount >= 500 ? "High withdrawal!" : "Low withdrawal.");
        }
        else
        {
            Console.WriteLine("Invalid amount or insufficient balance.");
        }
    }
}