using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Array ucun ededler daxil edin: ");

            //Write array
            for (int x = 0; x<5; x++)
            { 
                arr[x] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("\r\nArray-e daxil olunan ededler: ");
            
            //Read array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



            Console.ReadKey();
        }
    }
}
