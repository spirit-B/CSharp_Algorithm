using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string str = input[0];
        int num = int.Parse(input[1]);
        Console.WriteLine(string.Concat(Enumerable.Repeat(str, num)));
    }
}