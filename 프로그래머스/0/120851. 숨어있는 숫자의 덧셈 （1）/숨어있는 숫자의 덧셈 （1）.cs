using System;
using System.Linq;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        // foreach (char c in my_string)
        // {
        //     if (char.IsDigit(c)) answer += int.Parse(c.ToString());
        // }
        // my_string.Where(char.IsDigit).Select(c => answer += int.Parse(c.ToString())).ToArray();
        return my_string.Where(char.IsDigit).Sum(c => int.Parse(c.ToString()));
    }
}