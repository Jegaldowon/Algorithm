public class Solution
{
    public double solution(int[] numbers)
    {
        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum / numbers.Length;
    }
}