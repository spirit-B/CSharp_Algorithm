using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        for (int i = 1; i < numLog.Length; i++)
        {
            int minus = numLog[i] - numLog[i - 1];
            if (minus == 1) answer += 'w';
            else if (minus == -1) answer += 's';
            else if (minus == 10) answer += 'd';
            else answer += 'a';
        }
        return answer;
    }
}