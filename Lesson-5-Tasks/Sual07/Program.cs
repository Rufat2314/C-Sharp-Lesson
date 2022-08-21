using System;

namespace Sual07
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ozum elediyim usul 1

            int[] arr = new int[] { 118, 141, 12, 84, 158, 1, 0, -10, 157 };

            int score = 0;
            int maximum = 0;
            int minimum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int z = 0; z < arr.Length; z++)
                {
                    if (arr[i] - arr[z] <= 0)
                    {
                        score += 0;
                    }
                    else
                    {
                        score += 1;
                    }
                }

                Console.WriteLine(arr[i] + " " + score);

                if (score == 0)
                {
                    minimum = arr[i];
                }

                if (score == arr.Length - 1)
                {
                    maximum = arr[i];
                }

                score = 0;    //score sifirlanir
            }

            Console.WriteLine("\r\n" + minimum + " Array arasinda en kicik ededdir");
            Console.WriteLine(maximum + " Array arasinda en boyuk ededdir");


            // 2ci usul

            //Array.Sort(arr);

            //Console.WriteLine("Minimum deyer: " + arr[0]);
            //Console.WriteLine("Maximum deyer: " + arr[arr.Length - 1]);




            Console.ReadKey();
        }
    }
}
