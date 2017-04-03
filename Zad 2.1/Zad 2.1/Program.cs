using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            AstonMartin pierwszy = new AstonMartin();
            RangeRover drugi = new RangeRover();
            RollsRoyce trzeci = new RollsRoyce();
            wypisz(pierwszy);
            wypisz(drugi);
            wypisz(trzeci);

            Console.ReadKey();
        }
        static void wypisz(ISamochod samochod)
        {
            Console.WriteLine(samochod.WypiszMarke());
            Console.WriteLine(samochod.WypiszSalon());
        }
    }
}