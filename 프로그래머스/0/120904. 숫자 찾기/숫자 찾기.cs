using System;

public class Solution {
    public int solution(int num, int k) {
        string numStr = num.ToString();
        string inputStr = k.ToString();
        return numStr.Contains(inputStr) ? numStr.IndexOf(inputStr) + 1: -1;
    }
}