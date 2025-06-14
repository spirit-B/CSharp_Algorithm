using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        string[] str = letter.Split(" ");
        for (int i = 0; i < str.Length; i++)
        {
            char c = (char)(Array.FindIndex(morse, e => e == str[i]) + 97);
            answer += c.ToString();
        }
        
        return answer;
    }
}