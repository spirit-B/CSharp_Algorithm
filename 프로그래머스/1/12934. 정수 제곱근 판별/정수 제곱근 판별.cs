using System;

public class Solution {
    public long solution(long n) {
        int answer;
        
        return int.TryParse(Math.Sqrt(n).ToString(), out answer) ? 
            answer > 0 ? ((long)answer + 1) * (answer + 1) : -1 : -1;
    }
}