using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        List<int> answer = new List<int>();
        
        foreach (string num in intStrs)
        {
            int nums = int.Parse(num.Substring(s, l));
            if (nums > k) answer.Add(nums);
        }
        return answer.ToArray();
    }
}