using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        for (int i = 0; i < parts.GetLength(0); i++)
        {
            int start = parts[i, 0];
            int end = parts[i, 1] - start + 1;
            answer += my_strings[i].Substring(start, end);
        }
        
        
        return answer;
    }
}