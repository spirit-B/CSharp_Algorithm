using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        char[] str = my_string.ToCharArray();
        Array.Reverse(str, s, e - s + 1);
        
        return new string(str);
    }
}