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

        // ----- Store the numbers -----
        double[] numbers = new double[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // ----- Update the array values -----
        for (int i = 0; i < numbers.Length; i++)
        {
            int divisor = i + 1;

            // The check prevents division by zero.
            if (divisor > 0)
            {
                numbers[i] = numbers[i] / divisor;
            }
            else
            {
                Console.WriteLine("The divisor must be greater than zero.");
            }
        }

        // ----- Display the new values -----
        Console.Write("The new array values are :");

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]);

    if (i < numbers.Length - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine();
    }
}
