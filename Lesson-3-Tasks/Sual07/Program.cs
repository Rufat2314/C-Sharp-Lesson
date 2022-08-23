using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int rand1 = rand.Next(0, 100);
            int rand2 = rand.Next(0, 100);

            Console.WriteLine($"{rand1} + {rand2} = {rand1 + rand2}");

            Console.ReadKey();
        }
    }
}
