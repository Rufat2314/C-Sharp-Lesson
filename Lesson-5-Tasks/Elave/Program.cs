using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add even numbers to array
            int[] arr = new int[10];

            int count = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    arr[count] = i;
                    count++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



            // Find Min and Max elementlerin tapilmasi

            int r = arr[0];  // 2 4 6 8 10

            for (int i = 0; i < arr.Length; i++)
            {
                if (r < arr[i])
                {
                    r = arr[i];
                }
                
            }


            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
