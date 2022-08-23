using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 Herf Yazin:");
            char first = Convert.ToChar(Console.Read());
            char second = Convert.ToChar(Console.Read());
            char third = Convert.ToChar(Console.Read());
            string all = $"{third}{second}{first}";

            Console.WriteLine(all);

            Console.ReadKey();

        }
    }
}
