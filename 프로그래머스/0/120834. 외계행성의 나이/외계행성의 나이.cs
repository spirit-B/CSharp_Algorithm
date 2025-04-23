using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        string nums = age.ToString();
        
        for(int i = 0; i < nums.Length; i++)
        {
            answer += Convert.ToChar(int.Parse(nums[i].ToString()) + 97);   
        }
        return answer;
    }
}