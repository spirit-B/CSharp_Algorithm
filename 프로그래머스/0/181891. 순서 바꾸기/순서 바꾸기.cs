using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] front = num_list.Take(n).ToArray();
        int[] back = num_list.Skip(n).ToArray();
        return back.Concat(front).ToArray();
    }
}