using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kilograms = 0;
            Console.Write("Unesite vredost u kilogramima>");
            kilograms=Convert.ToInt32(Console.ReadLine());

            int grams = WeightConevrsion.Kg2Gr(kilograms);

            Console.WriteLine("{0} kg iznosi {1}", kilograms, grams);

            Console.ReadKey();
        }
    }
}
