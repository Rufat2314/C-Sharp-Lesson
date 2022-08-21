using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Sumqayit";

            bool b = (str.Length <= 10 && str.StartsWith("A")) ? true : false;

            switch (b)
            {
                case true:
                    Console.WriteLine(str.Length * 2);
                    break;
                default:
                    Console.WriteLine(str.Length);
                    break;
            }

            Console.ReadKey();
        }
    }
}
