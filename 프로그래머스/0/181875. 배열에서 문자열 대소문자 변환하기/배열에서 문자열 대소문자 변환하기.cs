using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
        return strArr.Select((s, i) => i % 2 ==0 ? s.ToLower() : s.ToUpper()).ToArray();
    }
}