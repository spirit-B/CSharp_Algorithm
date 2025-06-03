using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public long solution(long n) {
        List<Char> nums = n.ToString().ToList().OrderByDescending(x => x).ToList();
        return long.Parse(nums.ToArray());
    }
}