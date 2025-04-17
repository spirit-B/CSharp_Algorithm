using System;

public class Solution {
    // 최대공약수
    public int gcd(int a, int b)
    {
        return a % b == 0 ? b : gcd(b, a % b);
    }
    
    // 최소공배수
    public int lcm(int a, int b)
    {
        return a * b / gcd(a, b);
    }
    
    public int solution(int n) {
        return lcm(6, n) / 6;
    }
}