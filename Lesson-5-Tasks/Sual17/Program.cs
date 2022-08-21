using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] str = new string[3, 3] { 
                {"element1","element2","element3"},
                {"elem4","elem5","elem6"},
                {"el7","el8","el9"}
            };

            for (int i = 0; i < str.GetLength(0); i++)
            {
                for (int a = 0; a < str.GetLength(1); a++)
                {
                    Console.WriteLine( str[i,a]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
