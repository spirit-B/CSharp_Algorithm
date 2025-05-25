using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        // string nums = n.ToString();
        // foreach(char num in nums)
        // {
        //     answer += int.Parse(num.ToString());
        // }
        while (n > 0)
        {
            answer += n % 10;
            n /= 10;
        }
        
        return answer;
    }
}