using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            string str = (number < 100) ? "Eded 100-den kicikdir ": null ;

           
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
