using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual09
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            string dateNow = dt.ToString("dd/MM/yyyy");

            Console.WriteLine("Tarix daxil edin:");
            
            #region INPUTS START ---------------------
            Console.Write("Gün: ");
            string day = Console.ReadLine();

            Console.Write("Ay: ");
            string month = Console.ReadLine();

            Console.Write("İl: ");
            string year = Console.ReadLine();
            #endregion INPUTS END ---------------------

            string inputDate = String.Format("{0}.{1}.{2}", day, month, year);

            string contition = dateNow == inputDate ? "Cari tarix doğrudur" : "Cari tarix yanlişdir";


            Console.WriteLine("\r\n" + "Daxil olunan tarix: " + inputDate);
            Console.WriteLine("Cari tarix: " + dateNow);


            Console.WriteLine("\r\n" + contition);

                       

            Console.ReadKey();

        }
    }
}
