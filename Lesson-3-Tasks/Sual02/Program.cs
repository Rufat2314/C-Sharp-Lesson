using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adiniz:");
            string name = Console.ReadLine().ToUpper();

            Console.WriteLine("Soyadiniz:");
            string sname = Console.ReadLine().ToUpper();

            Console.WriteLine(name + " " + sname);

            Console.ReadKey();
        }
    }
}
