using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        if (arr.Length == 1)
            return new int[] { -1 };

        int min = arr.Min();
        List<int> list = new List<int>(arr);
        list.Remove(min);

        return list.ToArray();
    }
}
