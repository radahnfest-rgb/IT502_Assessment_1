using System;

class Program
{
    static void Main()
    {
        // ----- Get product details -----
        Console.Write("Enter product name: ");
        string productName = Console.ReadLine() ?? "";

        Console.Write("Enter product quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter product cost per unit: $");
        decimal unitCost = Convert.ToDecimal(Console.ReadLine());

        if (quantity <= 0 || unitCost < 0)
        {
            Console.WriteLine("Quantity must be positive and cost cannot be negative.");
            return;
        }

        Console.Write("Is GST already included in the cost? (Y/N): ");
        string gstChoice = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();

        // ----- Calculate GST -----
        decimal enteredCost = unitCost * quantity;
        decimal costBeforeGst;
        decimal gstAmount;
        decimal totalCost;

        if (gstChoice == "N")
        {
            costBeforeGst = enteredCost;
            gstAmount = enteredCost * 0.15m;
            totalCost = enteredCost + gstAmount;
        }
        else if (gstChoice == "Y")
        {
            gstAmount = enteredCost * 3m / 23m;
            costBeforeGst = enteredCost - gstAmount;
            totalCost = enteredCost;
        }
        else
        {
            Console.WriteLine("Please enter Y or N for the GST option.");
            return;
        }

        // ----- Display the result -----
        Console.WriteLine();
        Console.WriteLine($"Product: {productName}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Cost before GST: ${costBeforeGst:F2}");
        Console.WriteLine($"GST amount: ${gstAmount:F2}");
        Console.WriteLine($"Total cost including GST: ${totalCost:F2}");
    }
}
