using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ----- Get the number -----
        Console.Write("Enter a number you want to find the factors for: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive whole number.");
            return;
        }

        // ----- Find the factors -----
        List<int> factors = new List<int>();

        for (int factor = 1; factor <= number; factor++)
        {
            if (number % factor == 0)
            {
                factors.Add(factor);
            }
        }

        // ----- Display the factors -----
        Console.WriteLine($"The factors of {number} are : {string.Join(", ", factors)}");
    }
}
