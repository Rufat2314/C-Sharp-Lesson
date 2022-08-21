using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual07V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];


            Random rand = new Random();


            //Write
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(0, 100);
            }

            //Read
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }



            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];  // 3, 2, 1, 4, 5
                }
            }

            Console.WriteLine(min + " Minimum eded");
        }
    }
}
