using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array-deki cut ededlerin cemi
            int[] arr = new int[] { 118, 141, 12, 84, 158, 1, 0, -10, 157 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
