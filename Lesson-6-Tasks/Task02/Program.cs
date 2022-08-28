using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop dell = new Laptop(14, "SSD");            
            dell.setValue("3 GB");


            Console.WriteLine("Screen size: " + dell.screen);
            Console.WriteLine("Memory Type: " + dell.memory);
            Console.WriteLine("Ram memory: " + dell.getValue());

            Console.ReadKey();

        }
    }
}
