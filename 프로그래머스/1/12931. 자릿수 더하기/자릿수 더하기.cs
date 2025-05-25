using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        string nums = n.ToString();
        foreach(char num in nums)
        {
            answer += int.Parse(num.ToString());
        }
        
        return answer;
    }
}