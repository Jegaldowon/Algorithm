using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.반복문
{
    internal class For_12
    {
        static void Main()
        {


            while (true)
            {
                string? input = Console.ReadLine();

                if (input == null) break;

                string[] s = input.Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                Console.WriteLine(a + b);


            }
        }
    }
}
