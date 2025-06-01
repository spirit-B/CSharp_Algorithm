using System;

public class Solution {
    public long solution(int a, int b) {
        // int length = (Math.Abs(b - a) + 1);
        // if (length % 2 == 0)
        // {
        //     return ((long)a + b) * (Math.Abs(b - a) / 2);
        // }
        // else
        // {
        //     return ((long)a + b) * (Math.Abs(b - a) / 2) + ((a + b) / 2);
        // }
        long answer = 0;
        
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        if (a == b) return a;
        
        for (int i = min; i <= max; i++)
        {
            answer += i;
        }
        
        return answer;
    }
}