using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededlerin tek ve ya cut oldugunu oyrenmek ucun Iki eded daxil edin: ");

            Console.Write("A ededi: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B ededi: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
               Console.WriteLine("'A' ededi ne tekdir, ne de cut.");
            }
            else if (a % 2 == 1)
            {
                Console.WriteLine("'A' ededi tekdir.");
            }
            else 
            {
                 Console.WriteLine("'A' ededi cutdur.");
            }



            if (b == 0)
            {
                Console.WriteLine("'B' ededi ne tekdir, ne de cut.");
            }
            else if (b % 2 == 1)
            {
                Console.WriteLine("'B' ededi tekdir.");
            }
            else
            {
                Console.WriteLine("'B' ededi cutdur.");
            }



            //Console.WriteLine(a + b);



            Console.ReadKey();


        }
    }
}
