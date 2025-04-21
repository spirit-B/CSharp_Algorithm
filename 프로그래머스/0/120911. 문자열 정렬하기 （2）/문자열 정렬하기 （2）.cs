using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        string answer = my_string.ToLower();
        return new string(answer.ToCharArray().OrderBy(c => c).ToArray());
    }
}