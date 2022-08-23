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
            Console.WriteLine("Dairenin radiusunu yazin (sm):");
            int radius = Convert.ToInt32(Console.ReadLine());
            
            double perimetr = 2 * Math.PI * radius; // C = 2 pi r
            Console.WriteLine("Cevrenin perimetri: " + perimetr + " sm");

            double sahe = Math.PI * Math.Pow(radius, 2);  // S = pi r2 
            Console.WriteLine("Cevrenin sahesi: " + sahe + " sm2"); 
            
            Console.ReadKey();

        }
    }
}
