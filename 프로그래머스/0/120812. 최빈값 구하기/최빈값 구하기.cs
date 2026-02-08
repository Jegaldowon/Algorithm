using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int i in array)
        {
            if (dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict[i] = 1;
            }
        }

        // 값 찾기
        // int maxCount = dict.Values.Max();
        int maxCount = 0;
        foreach (int i in array)
        {
            if (dict[i] > maxCount)
            {
                maxCount = dict[i];
            }
        }

        // 최빈값이 여러개인지 확인
        foreach (int i in array)
        {
            if (dict[i] == maxCount)
            {
                if (answer == 0)
                {
                    answer = i;
                }
                else if (answer != i)
                {
                    return -1;
                }
            }
        }


        return answer;

    }
}