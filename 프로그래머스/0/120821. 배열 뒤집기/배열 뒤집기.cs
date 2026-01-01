using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[num_list.Length];

        for (int i = 0; i < num_list.Length; i++)
        {
            answer[num_list.Length - i - 1] = num_list[i];
        }

        return answer;
    }
}