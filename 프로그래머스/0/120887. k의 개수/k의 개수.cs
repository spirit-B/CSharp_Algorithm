using System;
using System.Linq;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        
        for (; i <= j; i++)
        {
            int c = i.ToString().Count(x => x.ToString() == k.ToString());
            answer += c;
        }
        return answer;
    }
}