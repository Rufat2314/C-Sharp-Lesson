using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[] {"Nurlan", "Haci" };
            
            bool check = str[0] is string;

            if (check)
            {
                Console.WriteLine(str.GetLength(0));
            }
           
            
            Console.ReadKey();
        }
    }
}
