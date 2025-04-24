using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        List<int> multiple = new List<int>() {};
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                else
                {
                    multiple.Add(numbers[i] * numbers[j]);
                }
            }
        }
        return multiple.Max();
    }
}