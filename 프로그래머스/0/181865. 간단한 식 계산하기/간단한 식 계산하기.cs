using System;

public class Solution {
    public int solution(string binomial) {
        string[] split = binomial.Split(' ');
        if (split[1] == "+")
        {
            return int.Parse(split[0]) + int.Parse(split[2]);
        }
        else if (split[1] == "-")
        {
            return int.Parse(split[0]) - int.Parse(split[2]);
        }
        else
        {
            return int.Parse(split[0]) * int.Parse(split[2]);
        }
    }
}