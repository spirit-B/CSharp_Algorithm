using System;

public class Solution {
    public int solution(int a, int b) {
        int aAndb = int.Parse("" + a + b);
        int bAnda = int.Parse("" + b + a);
        return aAndb > bAnda ? aAndb : bAnda;
    }
}