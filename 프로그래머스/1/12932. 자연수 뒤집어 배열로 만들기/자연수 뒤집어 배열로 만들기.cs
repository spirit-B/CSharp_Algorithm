using System.Collections.Generic;

public class Solution {
    public int[] solution(long n) {
        Stack<int> answer = new Stack<int>();
        string nums = n.ToString();
        
        foreach (char num in nums)
        {
            answer.Push(int.Parse(num.ToString()));
        }
        
        return answer.ToArray();
    }
}