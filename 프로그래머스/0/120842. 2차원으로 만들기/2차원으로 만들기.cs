using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length / n, n];
        
        // [0, 0]	[0, 1]	[1, 0]	[1, 1]	[2, 0]	[2, 1]	[3, 0]	[3, 1]
        // 0	    1	    2	    3	    4	    5	    6	    7
        
        for (int i = 0; i < num_list.Length; i++)
        {
            answer[i / n, i % n] = num_list[i];
        }
        return answer;
    }
}