using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Solution {
    public string[] solution(string myStr) {
        string pattern = "[abc]";
        string[] answer = Regex.Split(myStr, pattern).Where(x => !string.IsNullOrEmpty(x)).ToArray();
        return answer.Length == 0 ? new string[] { "EMPTY" } : answer;
    }
}