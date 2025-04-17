using System;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] answer = new ArraySegment<int>(numbers, num1, num2 - num1 + 1).ToArray();
        return answer;
    }
}