using System;
using System.Text.RegularExpressions;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'a' || myString[i] == 'A')
                answer += myString[i].ToString().ToUpper();
            else
                answer += myString[i].ToString().ToLower();
        }
        return answer;
    }
}