using System;

public class Example
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is even");
        }
        else
        {
            Console.WriteLine($"{num} is odd");
        }
    }
}