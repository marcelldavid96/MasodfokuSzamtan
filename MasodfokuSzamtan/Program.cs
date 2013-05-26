using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasodfokuSzamtan
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Hello, a nevem Másodfokú Számtan!");
            Console.ReadLine();
            Console.WriteLine("Add meg a másodfokú együtthatót!");
            double masodfokuEgyutthato = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az elsőfokú együtthatót!");
            double elsofokuEgyutthato = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a konstanst!");
            double konstans = double.Parse(Console.ReadLine());

            double diszkriminans = ((elsofokuEgyutthato * elsofokuEgyutthato) - 4 * masodfokuEgyutthato * konstans);
            Console.WriteLine("A diszkrimináns =" + diszkriminans);
            Console.ReadLine();

            if (2 * masodfokuEgyutthato == 0)
            {
                Console.WriteLine("A nevező értéke nulla, a művelet értelmetlen!");
            }
            else
            {
                if (diszkriminans < 0)
                {
                    Console.WriteLine("Az egyenletnek nincs valós gyöke!");
                }
                if (diszkriminans == 0)
                {
                    Console.WriteLine("Az egyenletnek csak egyetlen valós gyöke van!");
                    double egyetlenXErtek = (-1 * elsofokuEgyutthato + Math.Sqrt(diszkriminans)) / (2 * masodfokuEgyutthato);
                }
                if (diszkriminans > 0)
                {
                    Console.WriteLine("Az egyenletnek két valós gyöke van!");
                    double elsoXErtek = (-1 * elsofokuEgyutthato + Math.Sqrt(diszkriminans)) / (2 * masodfokuEgyutthato);
                    Console.WriteLine("Az első gyöke az egyenletnek =" + elsoXErtek);
                    double masodikXErtek = (-1 * elsofokuEgyutthato - Math.Sqrt(diszkriminans)) / (2 * masodfokuEgyutthato);
                    Console.WriteLine("A második gyöke az egyenletnek =" + masodikXErtek);
                }
            }
            Console.ReadLine();
            #endregion
        }
    }
}
