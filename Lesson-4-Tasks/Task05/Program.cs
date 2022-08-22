using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odd and Even Numbers
            int a = Int32.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine(a + " ededi ne tek, ne de cutdur.");
            }
            else if(a%2 == 0)
            {
                Console.WriteLine(a + " ededi cutdur.");
            }
            else
            {
                Console.WriteLine(a + " ededi tekdir."); 
            }

            //Main(args);

            Console.ReadKey();

        }

        
    }
}
