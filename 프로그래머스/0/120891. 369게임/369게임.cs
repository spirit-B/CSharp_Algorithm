using System;

public class Solution {
    public int solution(int order)
    {
        int answer = 0;
        foreach (char c in order.ToString())
        {
            int num = int.Parse(c.ToString());
            if (num % 3 == 0 && num != 0) answer++;
        }

        return answer;
    }
}