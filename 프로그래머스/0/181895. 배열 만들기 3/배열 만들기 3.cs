using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        List<int> answer = new List<int>();
        
        for (int i = 0; i < intervals.GetLength(0); i++)
        {
            int start = intervals[i, 0];
            int end = intervals[i, 1];
            int length = end - start + 1;
            int[] newArr = arr.Skip(start).Take(length).ToArray();
            
            answer.AddRange(newArr);
        }
        return answer.ToArray();
    }
}