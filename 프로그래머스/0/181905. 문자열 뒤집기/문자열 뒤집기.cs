using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string str = my_string.Substring(s, e - s + 1);
        string newStr = new string(str.Reverse().ToArray());
        
        return my_string.Replace(str, newStr);
    }
}