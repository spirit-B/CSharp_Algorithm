using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        List<int> answer = new List<int>();
        for (int i = 1; i * k <= n; i++)
        {
            answer.Add(i * k);
        }
        return answer.ToArray();
    }
}