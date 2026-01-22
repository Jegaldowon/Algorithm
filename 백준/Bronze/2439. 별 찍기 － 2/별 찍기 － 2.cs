using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.반복문
{
    internal class For_10
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                for (global::System.Int32 j = 0; j < N - i; j++)
                {
                    Console.Write(" ");
                }

                for (global::System.Int32 k = 0; k < i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
