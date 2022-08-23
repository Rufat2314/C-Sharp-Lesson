using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iki cumle daxil edin ve ikincinin birinci cumlede olub olmadigini yoxlasin");

            Console.WriteLine("Cumle 1: ");
            string a = Console.ReadLine();

            Console.WriteLine("Cumle 2: ");
            string b = Console.ReadLine();

            Console.WriteLine(a.Contains(b));

            Console.ReadKey();

        }
    }
}
