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
            for (int i = 2; i <= 50; i++)
            {
                if (i%3 != 0)
                {
                    Console.Write(i + " ");
                }
                
            }


            Console.ReadKey();
        }
    }
}
