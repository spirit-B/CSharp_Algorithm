using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string pattern = "[a-zA-Z]";
        
        // 알파벳 대소문자를 기준으로 Split 한 후, 빈 문자열 제거
        string[] nums = Regex.Split(my_string, pattern).Where(x => !string.IsNullOrEmpty(x)).ToArray();
        
        for(int i = 0; i < nums.Length; i++)
        {
            answer += int.Parse(nums[i]);
        }
        
        return answer;
    }
}