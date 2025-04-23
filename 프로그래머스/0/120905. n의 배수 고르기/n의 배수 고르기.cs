using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        return numlist.ToList().Where(i => i % n == 0).ToArray();
    }
}