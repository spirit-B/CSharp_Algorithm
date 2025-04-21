using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        char[] answer = my_string.ToCharArray();
        char temp = my_string[num1];
        Console.WriteLine(temp);
        answer[num1] = my_string[num2];
        answer[num2] = temp;
        return string.Join("", answer);
    }
}