using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k) {
        return k % 2 == 0 ?
            arr.Select(x => x + k).ToArray()
            : arr.Select(x => x * k).ToArray();
    }
}