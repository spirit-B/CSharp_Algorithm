public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        long num = (long)x;
        long plus = num;
        for (int i = 0; i < n; i++)
        {
            answer[i] = num;
            num += plus;
        }
        return answer;
    }
}