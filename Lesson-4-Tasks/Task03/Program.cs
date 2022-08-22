using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            double numb = rand.NextDouble()*5+1;
            Console.WriteLine(numb);

            Console.WriteLine("Round Floor: " + Math.Floor(numb));
            Console.WriteLine("Round Ceiling: " + Math.Ceiling(numb));


            Console.ReadKey();
        }
    }
}
