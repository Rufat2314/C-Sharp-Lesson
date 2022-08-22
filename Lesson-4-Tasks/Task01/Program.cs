using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual1
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "24";

            int number = Convert.ToInt32(obj);

            float flo = float.Parse((string)obj);
            double dbl = Convert.ToInt64(obj);
            string str = (string)obj;
            
            Console.WriteLine("Object to int: " + number);
            Console.WriteLine("Object to float: " + flo);
            Console.WriteLine("Object to string: " + str);
            

            Console.ReadKey();
        }
    }
}
