using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(2 + " " + 3 + " ");

            for (int i = 1; i <= 16; i++)
            {
                Console.Write((6 * i - 1) + " ");
                Console.Write((6 * i + 1) + " ");

                // Dustur 6n + 1 və 6n – 1
            }

            Console.ReadKey();
        }
    }
}
