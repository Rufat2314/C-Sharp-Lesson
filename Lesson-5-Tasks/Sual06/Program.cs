using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1, 2, 3, 4, 5};

            arr[1] = 20;

            //Read array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }
    }
}
