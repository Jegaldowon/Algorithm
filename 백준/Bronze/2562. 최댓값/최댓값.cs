using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array
{

    internal class Array_03
    {
        static void Main()
        {
            int[] myArray = new int[10];

            for (int i = 0; i < 9; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
                
            }

            int maxIndex;
            int max = MaxNum(myArray, out maxIndex);


            Console.WriteLine(max);
            Console.WriteLine(maxIndex + 1);



        }


        static int MaxNum(int[] arr, out int index)
        {
            int max = arr[0];
            index = 0;
            

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                    
                }

            }
            return max;

        }

   

    }
}
