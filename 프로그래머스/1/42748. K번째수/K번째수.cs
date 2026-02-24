using System;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int commandCount = commands.GetLength(0);
        int[] answer = new int[commandCount]; 
        
        for (int c = 0; c < commandCount; c++)
        {

            int i = commands[c, 0];
            int j = commands[c, 1];
            int k = commands[c, 2];        
     
            int length = j - i + 1;
            int[] temp = new int[length];

            
            for (int n = 0; n < length; n++)
            {
                
                temp[n] = array[(i - 1) + n];
            }

            // 배열정렬 
            Array.Sort(temp);
 
            answer[c] = temp[k - 1];
        }

        return answer;
    }
}