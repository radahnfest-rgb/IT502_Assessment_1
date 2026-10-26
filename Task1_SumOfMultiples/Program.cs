using System;

class Program
{
    static void Main()
    {
        // ----- User details -----
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "";
        Console.WriteLine($"Welcome {name}!");
        Console.WriteLine();

        // ----- Calculate the sum -----
        int sum = 0;

        for (int number = 1; number <= 100; number++)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                sum += number;
            }
        }

        // ----- Display result -----
        Console.WriteLine($"The sum of all multiples of 3 and 5 between 1 and 100 is : {sum}");
    }
}
