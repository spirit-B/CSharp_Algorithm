using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = num_list.OrderBy(n => n).Take(5).ToArray();
        return answer;
    }
}