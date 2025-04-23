using System;

public class Solution {
    public int solution(int[] sides) {
        Array.Sort(sides);
        int[] arrSorted = sides;
        
        return arrSorted[2] < arrSorted[0] + arrSorted[1] ? 1 : 2;
    }
}