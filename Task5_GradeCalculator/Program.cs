using System;

class GradeCalculator
{
    // ----- Calculate the average -----
    public double CalculateAverage(double maths, double physics, double chemistry, double computerScience)
    {
        return (maths + physics + chemistry + computerScience) / 4;
    }

    // ----- Find the grade -----
    public string CalculateGrade(double average)
    {
        if (average >= 80)
        {
            return "A";
        }
        else if (average >= 70)
        {
            return "B";
        }
        else if (average >= 60)
        {
            return "C";
        }
        else if (average >= 50)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // ----- Get subject marks -----
            double maths = ReadMark("Mathematics");
            double physics = ReadMark("Physics");
            double chemistry = ReadMark("Chemistry");
            double computerScience = ReadMark("Computer Science");

            // ----- Calculate the average and grade -----
            GradeCalculator calculator = new GradeCalculator();
            double average = calculator.CalculateAverage(maths, physics, chemistry, computerScience);
            string grade = calculator.CalculateGrade(average);

            Console.WriteLine();
            Console.WriteLine($"Average marks: {average:F2}");
            Console.WriteLine($"Grade: {grade}");

            // ----- Display the grade remark -----
            switch (grade)
            {
                case "A":
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case "B":
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case "C":
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case "D":
                    Console.WriteLine("Pass. Your grade is D");
                    break;
                case "F":
                    Console.WriteLine("Fail. Your grade is F");
                    break;
                default:
                    Console.WriteLine("Grade could not be determined.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Enter numeric marks between 0 and 100.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Each mark must be between 0 and 100.");
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occurred.");
        }
    }

    // ----- Read and check one mark -----
    static double ReadMark(string subject)
    {
        Console.Write($"Enter marks for {subject} (0-100): ");
        double mark = Convert.ToDouble(Console.ReadLine());

        if (mark < 0 || mark > 100)
        {
            throw new ArgumentOutOfRangeException();
        }

        return mark;
    }
}
