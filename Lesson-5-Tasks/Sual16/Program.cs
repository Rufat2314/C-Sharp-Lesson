using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual16
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numb = new double[] { 189.258, 58.987, 78, 1589, 5523.65 };
            double[] numbMultiplied = new double[numb.Length];

            // "numb" elements multiplied by 2
            for (int i = 0; i < numb.Length; i++)
            {
                numbMultiplied[i] = numb[i] * 2;
            }

            // Read "numbMultiplied"
            for (int a = 0; a < numbMultiplied.Length; a++)
            {
                Console.WriteLine(numbMultiplied[a]);
            }

            
            Console.ReadKey();
        }
    }
}
