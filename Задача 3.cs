using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        bool isValid = IsValidBracketString(input);
        Console.WriteLine(isValid);
    }

    public static Dictionary<char, char> CreateBracketMap()
    {
        Dictionary<char, char> bracketMap = new Dictionary<char, char>();
        bracketMap['('] = ')';
        bracketMap[')'] = '(';
        bracketMap['['] = ']';
        bracketMap[']'] = '[';
        bracketMap['{'] = '}';
        bracketMap['}'] = '{';

        return bracketMap;
    }

    public static bool IsValidBracketString(string s)
    {
        Dictionary<char, char> bracketsMap = CreateBracketMap();
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0 || stack.Pop() != bracketsMap[c])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
