using System;
using System.Linq;

public class Solution {
    public string solution(string myString) {
        // char[] answer = myString.ToCharArray();
        // for (int i = 0; i < answer.Length; i++)
        // {
        //     if (answer[i] < 'l') answer[i] = 'l';
        // }
        // return string.Concat(answer);
        string answer = new string(myString.Select(c => c < 'l' ? 'l' : c).ToArray());
        return answer;
    }
}