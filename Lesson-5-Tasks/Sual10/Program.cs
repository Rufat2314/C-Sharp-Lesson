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
            // Array azalan sira ile 
            int[] arr = new int[] { 118, 141, 12, 84, 158, 1, 0, -10, 157 };
            Array.Sort(arr);

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();

        }
    }
}
