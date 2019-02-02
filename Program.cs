change with tortoise
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        static void Main(string[] args)
        {
           int broidni = int.Parse(Console.ReadLine());
            int ostavenahrana = int.Parse(Console.ReadLine());
            var cat1 = double.Parse(Console.ReadLine());
            var cat2 = double.Parse(Console.ReadLine());

            double kotka1hrana = cat1  * broidni;
            double hrana2kotka = cat2 * broidni;
            double sum = kotka1hrana + hrana2kotka;

            if (ostavenahrana > sum)
            {
                Console.WriteLine("The cats are well fed;");
                Console.WriteLine("{0} kilos of food left .", Math.Ceiling(ostavenahrana - sum));
            }
            else
            {
                Console.WriteLine("The cats are hungry.");
                Console.WriteLine("{0} more kilos of food are needed .", Math.Floor(sum - ostavenahrana));
                



        }
        
    }
}
