using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        answer += my_string[c - 1];
        for (int i = c; i < my_string.Length; i++)
        {
            if (i % m == c - 1) answer += my_string[i];
        }
        return answer;
    }
}