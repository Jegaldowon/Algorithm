using System;
public class Solution
{
    public int[] solution(int num, int total)
    {
        int[] answer = new int[num];
        // num = 3;
        // total = 12;
        // result = 3,4,5;
        // total / 3 = 4 -> 가운데 값
        
        // i = 0 -> 3;
        // i = 1 -> 4;
        // i = 2 -> 5;
        
        // num = 4;
        // total = 14;
        // res = 2,3,4,5
        // 가운데 값 : 3 
        
        if (num % 2 == 0)
        {
            for (global::System.Int32 i = 0; i < num; i++)
            {
               
                answer[i] = (total / num) - (num / 2) + i + 1;
            }
        }

        else
        {
            for (global::System.Int32 i = 0; i < num; i++)
            {
                answer[i] = (total / num) - (num / 2) + i;
            }
        }
        return answer;
    }
}