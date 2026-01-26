using System;

public class Solution
{
    public int solution(int[] sides)
    {
        int count = 0;

        int a = sides[0];
        int b = sides[1];

        for (int c = 0; c < a+b; c++)
        {
            if(Math.Abs(a - b) < c) count++;
        }
        return count;

    }
}