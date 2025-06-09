using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        Stack<int> answer = new Stack<int>();
        
        for (int i = 0; i < flag.Length; i++)
        {
            if (flag[i] == true)
            {
                for (int j = 0; j < arr[i] * 2; j++)
                {
                    answer.Push(arr[i]);
                }
            }
            else
            {
                for (int k = 0; k < arr[i]; k++)
                {
                    answer.Pop();
                }
            }
        }
        
        return answer.Reverse().ToArray();
    }
}