public class Solution
{
    public int solution(int[] num_list)
    {
        int answer = 0;
        string evenNum = "";
        string oddNum = "";
        

        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                evenNum += num_list[i];
                
            }
            else
            {
                oddNum += num_list[i];
            }
            
            
        }
        
        return int.Parse(evenNum) +  int.Parse(oddNum);
    }
}