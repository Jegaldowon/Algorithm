using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        Console.WriteLine("{0:F9}", a / b);



    }
}


