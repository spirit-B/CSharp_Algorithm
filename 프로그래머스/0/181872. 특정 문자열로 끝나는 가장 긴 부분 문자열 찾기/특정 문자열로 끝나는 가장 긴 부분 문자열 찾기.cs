using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        
        for (int i = 0; i <= myString.Length; i++)
        {
            string newStr = myString.Substring(0, i);
            if (newStr.EndsWith(pat) && newStr.Length > answer.Length)
            {
                answer = newStr;
            }
        }
        
        return answer;
    }
}