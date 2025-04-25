using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int n) {
        if (arr.Length % 2 != 0)
        {
            return arr.Select((x, i) => i % 2 == 0 ? x + n : x).ToArray();
        }
        else
        {
            return arr.Select((x, i) => i % 2 == 0 ? x : x + n).ToArray();
        }
    }
}