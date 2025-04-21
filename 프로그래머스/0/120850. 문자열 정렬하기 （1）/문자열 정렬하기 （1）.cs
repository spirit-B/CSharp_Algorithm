using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        List<int> answer = new List<int>();

        for (int i = 0; i < my_string.Length; i++)
        {
            if (Char.IsNumber(my_string[i]))
            {
                answer.Add(int.Parse(my_string[i].ToString()));
            }
        }

        answer.Sort();
        return answer.ToArray();
    }
}