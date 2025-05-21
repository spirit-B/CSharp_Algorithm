using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list, int n) {
        // for (int i = 0; i < num_list.Length; i++)
        // {
        //     if (num_list[i] == n) return 1;
        // }
        // return 0;
        return Array.Exists(num_list, num => num == n) ? 1 : 0;
    }
}