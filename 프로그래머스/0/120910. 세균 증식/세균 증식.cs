using System;

public class Solution {
    public int solution(int n, int t) {
        return n * (int)Math.Pow(2, t);
        
        // 다른 풀이
        // int answer = n << t;
        // return answer;
    }
}