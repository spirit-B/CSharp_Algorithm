using System;

public class Solution {
    public int solution(int[] date1, int[] date2) {
        DateTime dateFirst = Convert.ToDateTime(string.Join("-", date1));
        DateTime dateSecond = Convert.ToDateTime(string.Join("-", date2));
        
        int compareDate = DateTime.Compare(dateFirst, dateSecond);
        
        if (compareDate == -1) return 1;
        else return 0;
    }
}