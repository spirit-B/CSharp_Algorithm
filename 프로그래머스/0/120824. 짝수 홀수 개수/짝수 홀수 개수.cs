using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {num_list.Count(n => n % 2 == 0), num_list.Count(n => n % 2 == 1)};
        return answer;
    }
}