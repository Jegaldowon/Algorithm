using System;

public class Example
{
    public static void Main()
    {
        string[] intput = Console.ReadLine().Split(' ');
        int x = int.Parse(intput[0]);

        if (x % 2 ==0)
        {
            Console.WriteLine($"{x} is even");
            
        }
        else
        {
            Console.WriteLine($"{x} is odd");
        }
        
        
    }
}