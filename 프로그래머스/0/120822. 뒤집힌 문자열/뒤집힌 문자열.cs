using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) {
        char[] strArr = my_string.ToArray();
        Array.Reverse(strArr);
        
        return string.Join("", strArr);
    }
}