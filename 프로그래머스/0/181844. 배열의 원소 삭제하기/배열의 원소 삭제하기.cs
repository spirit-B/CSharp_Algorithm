using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> newArr = arr.ToList();
        
        for (int i = 0; i < delete_list.Length; i++)
        {
            if (newArr.Contains(delete_list[i])) newArr.Remove(delete_list[i]);
        }
        return newArr.ToArray();
    }
}