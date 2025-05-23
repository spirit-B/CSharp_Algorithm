using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] new_list = num_list;
        Array.Sort(new_list);
        return new_list.Where((n, i) => i > 4).ToArray();
    }
}