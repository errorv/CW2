using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2._2
{
    class Mag:Bohater
    {
        public int Mana;

        public Mag(string nazwa, int hp, int atak, Rasa rasa, int mana) : base(nazwa, hp, atak, rasa)
        {
            Mana = mana;
        }
        public void RzucCzar(Bohater postac)
        {
            if (postac.Hp > 0)
            {
                if (Mana >= 20)
                {
                    this.Mana -= 20;
                    postac.Hp -= 100;
                    Console.WriteLine("{0} Wykonał rzut czarem w {1} i zabrał mu 100 punktów życia", Nazwa, postac.Nazwa);
                }
                else
                {
                    Console.WriteLine("Nie wystarczający poziom many", Nazwa);
                }


            }
            else
            {
                Console.WriteLine("Postać {0} nie żyje", postac.Nazwa);
            }


        }
    }
}