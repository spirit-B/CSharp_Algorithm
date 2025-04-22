using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                answer = answer.Concat(new int[] { i }).ToArray();
            }
        }
        return answer;
    }
}