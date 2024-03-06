using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Array of digits:");
        string input = Console.ReadLine();
        string numStr = input.Replace(" ", "");

        Int32 num = Int32.Parse(numStr);
        num += 1;

        Console.WriteLine(num);
    }
}
