using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string num_str) {
        List<int> numList = num_str.ToArray().Select(x => int.Parse(x.ToString())).ToList();
        return numList.Sum();
    }
}