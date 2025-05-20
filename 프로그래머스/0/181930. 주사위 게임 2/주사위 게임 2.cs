using System;

public class Solution {
    public int solution(int a, int b, int c) {
        if (a == b && a == c && b == c)
        {
            return CalPow(a, b, c, 3);
        }
        else if (a == b || a == c || b == c)
        {
            return CalPow(a, b, c, 2);
        }
        else
        {
            return CalPow(a, b, c, 1);
        }
    }
    
    // 결과 계산을 위한 함수
    public int CalPow(int a, int b, int c, int num)
    {
        int result = 1;

        for (int i = 1; i <= num; i++)
        {
            int aPow = 1, bPow = 1, cPow = 1;

            for (int j = 0; j < i; j++)
            {
                aPow *= a;
                bPow *= b;
                cPow *= c;
            }

            int sum = aPow + bPow + cPow;
            result *= sum;
        }

        return result;
    }
}