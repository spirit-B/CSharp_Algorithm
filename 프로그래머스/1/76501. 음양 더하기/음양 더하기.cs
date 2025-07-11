using System;
using System.Linq;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
//         int answer = 0;
        
//         for (int i = 0; i < signs.Length; i++)
//         {
//             if (signs[i] == true) answer += absolutes[i];
//             else answer -= absolutes[i];
//         }
//         return answer;
        return absolutes.Select((n, i) => signs[i] ? n : -n).Sum();
    }
}