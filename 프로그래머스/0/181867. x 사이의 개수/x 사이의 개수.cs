using System;
using System.Linq;

public class Solution {
    public int[] solution(string myString) {
        string[] answer = myString.Split("x");
        return answer.Select(x => x.Length).ToArray();
    }
}