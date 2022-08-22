using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;

            for (int i = 2; i <= (x/2); i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
