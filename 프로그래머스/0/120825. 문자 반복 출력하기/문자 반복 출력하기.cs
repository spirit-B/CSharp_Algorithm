using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        for (int i = 0; i < my_string.Length; i++)
        {
            answer += new String(my_string[i], n);
        }
        return answer;
    }
}