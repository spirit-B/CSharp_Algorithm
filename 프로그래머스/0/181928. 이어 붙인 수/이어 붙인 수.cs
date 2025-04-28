using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        string even = "";
        string odd = "";
        
        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                even += num_list[i];
            }
            else
            {
                odd += num_list[i];
            }
        }
        
        return int.Parse(even) + int.Parse(odd);
    }
}