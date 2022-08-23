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
            Console.Write("A ededi: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B ededi: ");
            int b = Convert.ToInt32(Console.ReadLine());

            float nisbet = (float)a/b;

            Console.WriteLine(nisbet);

            Console.ReadKey();
        }
    }
}
