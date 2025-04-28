using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) {
        List<string> answer = new List<string>();
        answer = names.Where((s, i) => i % 5 == 0).ToList();
        return answer.ToArray();
    }
}