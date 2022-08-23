using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Daxil edilen ededlerin muqayisesi
            int[] numbers = new int[3];

            #region INPUTS START ---------------------
            Console.Write("1 ci ededi daxil edin: ");
            numbers[0] = Int32.Parse(Console.ReadLine());

            Console.Write("2 ci ededi daxil edin: ");
            numbers[1] = Int32.Parse(Console.ReadLine());
            
            Console.Write("3 cu ededi daxil edin: ");
            numbers[2] = Int32.Parse(Console.ReadLine());
            #endregion INPUTS END ---------------------


            int max = numbers.Max(); // Maksimum eded
            int indexOfMax = Array.IndexOf(numbers, max); // Maksimum ededin indeksi

            Console.WriteLine("\r\n" + "Maksimum eded: " + max);

            if (indexOfMax == 0)
            {
                Console.WriteLine("\r\n" + "1ci - eded en boyuyudur");
            }
            else if (indexOfMax == 1)
            {
                Console.WriteLine("\r\n" + "2ci - eded en boyuyudur");
            }
            else
            {
                Console.WriteLine("\r\n" + "3cu - eded en boyuyudur");
            }

            Console.ReadKey();

        }
    }
}
