public class Solution {
    public string solution(string phone_number) {
        // int maskedCount = phone_number.Length - 4;
        // return new string('*', maskedCount) + phone_number.Substring(maskedCount);
        string answer = phone_number.Substring(phone_number.Length - 4);
        answer = answer.PadLeft(phone_number.Length, '*');
        return answer;
    }
}