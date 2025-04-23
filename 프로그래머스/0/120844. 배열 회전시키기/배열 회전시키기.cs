using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        List<int> answer = numbers.ToList();
        
        if (direction == "right")
        {
            int temp = answer.Last();
            answer.Remove(temp);
            answer.Insert(0, temp);
        }
        else
        {
            int temp = answer[0];
            answer.Remove(temp);
            answer.Add(temp);
        }
        
        return answer.ToArray();
    }
}