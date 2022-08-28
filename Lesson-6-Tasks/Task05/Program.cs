using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Random rand = new Random();
            Console.WriteLine("Tesadufi edeler ucun araliq teyin edin");

            Console.Write("Minimum eded: ");
            int minNum = Int32.Parse(Console.ReadLine());

            Console.Write("Maksimum eded: ");
            int maxNum = Int32.Parse(Console.ReadLine());

            int Rnd()
            {
               return rand.Next(minNum, maxNum);
            }


            Console.WriteLine(Rnd()); 

            Console.ReadKey();

        }
    }
}
