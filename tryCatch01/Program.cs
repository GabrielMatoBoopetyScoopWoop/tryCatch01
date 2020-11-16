using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int broj;
                Console.Write("Unesite broj = ");
                broj = Convert.ToInt32(Console.ReadLine());
                Console.Write("Uneseni broj = " + broj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
