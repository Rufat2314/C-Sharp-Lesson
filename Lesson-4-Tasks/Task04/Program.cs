using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Baki seheri");
            str.AppendLine("Sumqayit havasi");
            str.AppendLine("Merdekan yollari");

            Console.WriteLine(str);
            str.Clear();
            Console.WriteLine(str + "Datalar Silindi");


            Console.ReadKey();
        }
    }
}
