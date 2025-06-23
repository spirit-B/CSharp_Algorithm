using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        char[] arr1 = before.ToCharArray();
        char[] arr2 = after.ToCharArray();
        
        Array.Sort(arr1);
        Array.Sort(arr2);
        
        string beforeStr = new string(arr1);
        string afterStr = new string(arr2);
        
        return beforeStr == afterStr ? 1 : 0;
    }
}