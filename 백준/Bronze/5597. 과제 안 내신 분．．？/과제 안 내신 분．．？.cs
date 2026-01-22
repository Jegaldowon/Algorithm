using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.배열
{
    internal class Array_04
    {
        static void Main()
        {
            int[] students = new int[31];

            for (int i = 0; i < 28; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                students[studentNumber] = 1;
            }

            for (int i = 1; i <= 30; i++)
            {
                if (students[i] == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
