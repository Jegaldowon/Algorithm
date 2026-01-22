using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.조건문
{
    internal interface IF_06
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(Console.ReadLine());

            A += C / 60;
            B += C % 60;

            if (B >= 60)
            {
                A += 1;
                B -= 60;
            }
            if (A >= 24)
            {
                A -= 24;
            }
            Console.WriteLine($"{A} {B}");
        }
    }  
}
