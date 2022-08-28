using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        //Factorial
        public static int Factorial(int inputVal)
        {
            int summary = 1;

            for (int i = 1; i <= inputVal; i++)
            {
                summary = summary * i;
            } 

            return summary;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Faktorial hesablamaq ücün eded daxil edin: ");
            int userInput = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\r\n Daxil olunan ededin faktoriali: " + Factorial(userInput));

            Console.ReadKey();
            
        }
    }
}
