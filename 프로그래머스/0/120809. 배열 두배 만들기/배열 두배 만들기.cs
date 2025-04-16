using System;
// using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            answer[i] = numbers[i] * 2;
        }
        
        return answer;
    }
    // 다른 답안
    // System.Linq를 쓸것
    // public int [] solution(int[] numbers)
    // {
    //     int[] answer = numbers.Select(n => n *= 2).ToArray();
    //     return answer;
    // } 
}