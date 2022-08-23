using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Riyazi emeliyyatlar
            Console.WriteLine("Ededler uzerinde riyazi emeliyyat aparin:");

            Console.Write("Ilk ededi yazin: ");
            int first = Int32.Parse(Console.ReadLine());

            Console.Write("ikinci ededi yazin: ");
            int second = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\r\n" + "Riyazi operatoru secin:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Cixma");
            Console.WriteLine("3 - Vurma");
            Console.WriteLine("4 - Bolme" + "\r\n");

            int math = Int32.Parse(Console.ReadLine());

            switch (math)
            {
                case 1:
                    Console.WriteLine(first + second);
                    break;
                case 2:
                    Console.WriteLine(first - second);
                    break;
                case 3:
                    Console.WriteLine(first * second);
                    break;
                case 4:
                    Console.WriteLine(first / second);
                    break;
                default:
                    Console.WriteLine("Operatoru duzgun secmediniz");
                    break;
            }



            Console.ReadKey();
        }
    }
}
