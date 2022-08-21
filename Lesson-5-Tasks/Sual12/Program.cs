using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,,,,,,,,] multiArray = new int[1,1,1,1,1,1,1,1,1,10];

            // { { { { { { { { { { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 } } } } } } } } } } ;


            //Write elements to array

            int p = 1;

            for (int a = 0; a < multiArray.GetLength(9); a++)
            {
                int arrayVal = 0;                

                for (int i = p; i <= 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        arrayVal = i;
                        p = i+1;
                        break;
                    }
                    
                }
                multiArray[0, 0, 0, 0, 0, 0, 0, 0, 0, a] = arrayVal;                                
            }
                 
            //Read array elements
            for (int x = 0; x < multiArray.GetLength(9); x++)
            {
                Console.WriteLine(multiArray[0, 0, 0, 0, 0, 0, 0, 0, 0, x]);
            }







            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i); 
            //    }
            //}


            Console.ReadKey();
        }
    }
}
