using System;
using System.Text;

namespace CodingTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int input = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);


        }
    }
}
