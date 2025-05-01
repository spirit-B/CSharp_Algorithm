using System;

public class Solution {
    public int solution(int a, int b) {
        int temp1 = int.Parse($"{a}{b}");
        int temp2 = 2 * a * b;
        
        return temp1 == temp2
            ? temp1 : temp1 > temp2
                ? temp1 : temp2;
    }
}