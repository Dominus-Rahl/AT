using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Array:");
        string input = Console.ReadLine();

        string[] numbersStr = input.Split(' ');
        int[] numbers = new int[numbersStr.Length];

        for (int i = 0; i < numbersStr.Length; i++)
        {
            numbers[i] = int.Parse(numbersStr[i]);
        }

        Console.WriteLine(OnesCountMax(numbers));
    }

    static int OnesCountMax(int[] nums)
    {
        int max = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else
            {
                count = 0;
            }
        }

        return max == 1 ? 0 : max;
    }

}