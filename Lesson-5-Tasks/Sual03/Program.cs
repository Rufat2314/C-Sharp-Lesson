using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual03
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int random = rand.Next(0, 10);

            Console.WriteLine("Random ededi tapmaga calisin (0-10):");

            int userInput = Int32.Parse(Console.ReadLine());

            bool boolean = true;
            

            while (boolean)
            {
                if (random == userInput)
                {
                    Console.WriteLine("Tebrikler, siz random ededi tapdiniz.");
                    boolean = false;
                }
                else
                {
                    Console.WriteLine("Bir daha sinayin");
                    userInput = Int32.Parse(Console.ReadLine());
                }
            }

            Console.ReadKey();
        }
    }
}
