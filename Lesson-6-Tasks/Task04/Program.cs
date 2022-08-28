using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededleri bosluq qoyaraq daxil edin: ");

            string inputElements = Console.ReadLine();
            string[] strNumbers = inputElements.Split(' ');

            int[] strNumbersToInt = new int[strNumbers.Length];
            

            //Add string elements to int array
            for (int i = 0; i < strNumbers.Length; i++)
            {
                strNumbersToInt[i] = Int32.Parse(strNumbers[i]);                
            }

            Array.Sort(strNumbersToInt); // Array sorted


            // Raed Array by descending order
            for (int i = strNumbersToInt.Length-1; i >= 0; i--)
            {
                Console.Write(strNumbersToInt[i] + " ");
            }

            

            Console.ReadKey();
        }
    }
}
