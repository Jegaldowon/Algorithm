using System;
using System.Collections.Generic;



public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        
        
        int[] daysToComplete = new int[progresses.Length];
        for (int i = 0; i < progresses.Length; i++)
        {
            int remainingWork = 100 - progresses[i]; // 남은 퍼센트
            int days = remainingWork / speeds[i];    // 일단 몫을 구함 (며칠 걸리는지)

            // 정확히 나누어 떨어지지 않으면 하루 더 일해야함
            if (remainingWork % speeds[i] != 0)
            {
                days++; // 증가 해주고
            }
            
            daysToComplete[i] = days;
        }

        // 각 기능이 완성되는 일 수를 기준으로 배포되는 기능의 개수를 계산
        List<int> deploymentCounts = new List<int>();
        int currentMaxDay = daysToComplete[0];
        int count = 1;

        for (int i = 1; i < daysToComplete.Length; i++)
        {
            if (daysToComplete[i] <= currentMaxDay)
            {
                count++;
            }
            else
            {
                deploymentCounts.Add(count);
                count = 1;
                currentMaxDay = daysToComplete[i];
            }
        }
        deploymentCounts.Add(count); 
     
        return deploymentCounts.ToArray();

    }
}