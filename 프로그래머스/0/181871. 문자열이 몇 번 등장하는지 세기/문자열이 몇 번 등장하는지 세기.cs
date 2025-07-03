using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString.Substring(i).StartsWith(pat)) answer++;
        }
        return answer;
    }
}