using System;

public class Example
{
    public static void Main()
    {
        String str;

        Console.Clear();
        str = Console.ReadLine();
        
        string answer = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsLower(str[i]))
            {
                answer += Char.ToUpper(str[i]);
            }
            else
            {
                answer += Char.ToLower(str[i]);
            }
        }
        
        Console.WriteLine(answer);
    }
}