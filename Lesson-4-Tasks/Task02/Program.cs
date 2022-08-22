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

            double number, result;
            Console.Write("Enter the Number : ");

            number = Convert.ToDouble(Console.ReadLine());
            result = Math.Ceiling(Math.Pow(number, (double)1 / 3));

            Console.Write("Cube Root : " + result);
            
            //int a = 27; // x**n = a
            //int n = 3;

            //int number = 0;

            //for (int i = a; i > 1; i=i/n) {

            //    number++;

            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("\r\n" + a + " Ededinin " + n + " cu dereceden koku " + number + " -dur.");

           
            Console.ReadKey();
        }
    }
}
