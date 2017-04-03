using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2._2
{
    class Wojownik : Bohater
    {
        public Wojownik(string nazwa, int hp, int atak, Rasa rasa) : base(nazwa, hp, atak, rasa)
        {
        }

        public void RzutToporem(Bohater postac)
        {
            if (postac.Hp > 0)
            {
                postac.Hp -= 50;
                Console.WriteLine("{0} wykonał rzut toporem w {1} i zabrał mu 50 punktów życia", Nazwa, postac.Nazwa);
            }
            else
            {
                Console.WriteLine("Postać {0} nie żyje", postac.Nazwa);
            }
        }
    }
}