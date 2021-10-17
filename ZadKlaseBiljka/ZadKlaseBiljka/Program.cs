using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakKlaseBiljka
{
    class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno hrast = new Bijelogoricno(true);

            Crnogoricno bor = new Crnogoricno(false);

            Console.WriteLine($"Pada li hrastu lišće? {hrast.OpadajuListovi}");

            Console.WriteLine();

            Console.WriteLine($"Pada li boru lišće? {bor.OpadajuListovi}");

            Console.ReadKey();
        }
    }
}
