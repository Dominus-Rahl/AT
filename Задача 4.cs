using System;

class Program
{
    public static void Main()
    {
        Console.Write("Number 1: ");
        string input1 = Console.ReadLine();

        Console.Write("Number 2: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            int sum = num1 + num2;
            Console.WriteLine("Sum: " + sum.ToString());
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
