using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(10, 60);
            

            Console.WriteLine("Eded daxil edin: ");
            int b = Int32.Parse(Console.ReadLine());
            

            if (a == b)
            {
                Console.WriteLine("Her iki ededler beraberdir");
            }

            else if(a > b)
            {
                Console.WriteLine("Random "+ a + " ededi " + b + " ededinden boyukdur.");
            }
            else
            {
                Console.WriteLine("Random " + a +" ededi " + b + " ededinden kicikdir.");
            }


            Console.ReadKey();
        }
    }
}
