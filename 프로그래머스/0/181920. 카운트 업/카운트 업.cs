using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        List<int> answer = new List<int>();
        for (int i = 0; i < end_num - start_num + 1; i++)
        {
            answer.Add(i + start_num);
        }
        return answer.ToArray();
    }
}