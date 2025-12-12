using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Array_02
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int min = int.Parse(input[0]);
            int max = int.Parse(input[0]);

            for (int i = 1; i < n; i++)
            {
                int num = int.Parse(input[i]);

                if (num < min) { min = num; }
                if (num > max) { max = num; }


            }
            Console.WriteLine($"{min} {max}");

        }
    
    }
}
