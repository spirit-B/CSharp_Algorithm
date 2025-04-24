using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>() {};
        if (n == 1)
        {
            answer.Add(n);
        }
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                answer.Add(i);
                answer.Add(n / i);
            }
        }
        answer = answer.Distinct().ToList();
        answer.Sort();
        return answer.ToArray();
    }
}