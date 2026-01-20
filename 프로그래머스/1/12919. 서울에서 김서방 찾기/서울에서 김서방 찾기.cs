public class Solution
{
    public string solution(string[] seoul)
    {
        string answer = "";
        string name = "Kim";

        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
                return $"김서방은 {i}에 있다";
            }
        }

        return answer;
    }
}