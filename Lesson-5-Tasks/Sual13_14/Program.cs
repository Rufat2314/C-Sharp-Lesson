using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual13_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sual 13
            int[,] twoDimens = new int[4, 3] {
                {10, 20, 30 },
                {21, 35, 46 },
                {56, 32, 12 },
                {78, 96, 58 },
            };

            //Sual 14
            for (int i = 0; i < twoDimens.GetLength(0); i++)
            {
                for (int z = 0; z < twoDimens.GetLength(1); z++)
                {
                    Console.Write(twoDimens[i, z] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
