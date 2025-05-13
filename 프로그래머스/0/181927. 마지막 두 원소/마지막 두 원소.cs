using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        List<int> answer = num_list.ToList();
        int len = num_list.Length;
        int last = num_list[len - 1];
        int before = num_list[len - 2];
        
        int result = last > before ? last - before : 2 * last;
        answer.Add(result);
        
        return answer.ToArray();
    }
}