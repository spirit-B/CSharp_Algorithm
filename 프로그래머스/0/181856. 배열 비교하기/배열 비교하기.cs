using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) 
    {
        if (arr1.Length > arr2.Length)
        {
            return 1;
        }
        else if (arr1.Length < arr2.Length)
        {
            return -1;
        }
        else
        {
            if (arr1.Sum() == arr2.Sum())
            {
                return 0;
            }
            else
            {
                return arr1.Sum() > arr2.Sum() ? 1 : -1;
            }
        }
    }
}