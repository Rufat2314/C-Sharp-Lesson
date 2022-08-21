using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbTwoD = new int[3, 3] {
                {18, 56, 78},
                {9, 95, 47},
                {32, 14, 69}
            };

            int[] numb = new int[9];  //new array
            int p = 0; //counter

            //"numbTwoD" Converter
            for (int i = 0; i < numbTwoD.GetLength(0); i++)
            {
                for (int a = 0; a < numbTwoD.GetLength(1); a++)
                {
                    numb[p] = numbTwoD[i, a];
                    p++;
                }
            }

            //Sual 18 Max value
            Console.WriteLine("Maximum deyer " + numb.Max());


            //Sual19 Min value
           Console.WriteLine("Minimum deyer " + numb.Min());


            Console.ReadKey();
        }
    }
}
