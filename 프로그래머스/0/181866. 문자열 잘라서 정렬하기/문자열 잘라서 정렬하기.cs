using System;
using System.Linq;

public class Solution {
    public string[] solution(string myString) {
        return myString.Split("x", StringSplitOptions.RemoveEmptyEntries).OrderBy(s => s).ToArray();
    }
}