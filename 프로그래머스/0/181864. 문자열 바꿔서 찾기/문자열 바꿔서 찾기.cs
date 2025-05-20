using System;
using System.Linq;

public class Solution {
    public int solution(string myString, string pat) {
        string newStr = new string(myString.Select(c => c == 'A' ? 'B' : 'A').ToArray());
        return newStr.Contains(pat) ? 1 : 0;
    }
}