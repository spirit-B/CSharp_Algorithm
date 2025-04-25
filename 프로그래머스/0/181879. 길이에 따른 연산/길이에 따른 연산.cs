using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        if (num_list.Length >= 11)
        {
            return num_list.Sum();
        }
        else
        {
            int num = 1;
            for (int i = 0; i < num_list.Length; i++)
            {
                num *= num_list[i];
            }
            return num;
        }
    }
}