using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[] {};
        answer = arr.Where(n => n % divisor == 0).OrderBy(x => x).ToArray();
        
        if (answer.Length == 0) return new int[] { -1 };
        else return answer;
    }
}