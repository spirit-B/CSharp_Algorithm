using System;

public class Solution {
    public string solution(string code) {
        string ret = "";
        int mode = 0;
        
        for (int i = 0; i < code.Length; i++)
        {
            if (code[i].ToString() == "1" && mode == 0)
            {
                mode = 1;
                continue;
            }
            else if (code[i].ToString() == "1" && mode == 1)
            {
                mode = 0;
                continue;
            }
            
            if (mode == 0)
            {
                ret += i % 2 == 0 ? code[i].ToString() : "";
            }
            else
            {
                ret += i % 2 == 1 ? code[i].ToString() : "";
            }
        }
        
        return ret == "" ? "EMPTY" : ret;
    }
}