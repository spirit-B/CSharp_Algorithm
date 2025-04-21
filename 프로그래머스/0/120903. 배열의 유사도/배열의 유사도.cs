using System;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        for (int i = 0; i < s1.Length; i++)
        {
            if (Array.Exists(s2, s => s == s1[i])) answer++;
        }
        return answer;
    }
}