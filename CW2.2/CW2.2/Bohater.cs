using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2._2
{
    abstract class Bohater : IBohater
    {
        public int Hp;
        public int Atak;
        protected Rasa rasa;
        public string Nazwa;



        public enum Rasa
        {
            Wojownik,
            Czlowiek,
            Mag
        }


        public Bohater(string nazwa, int hp, int atak, Rasa rasa)
        {
            Nazwa = nazwa;
            Hp = hp;
            Atak = atak;
            this.rasa = rasa;

        }
        public string SprawdzHp()
        {
            if (Hp > 0)
            {
                return "Postać żyję";
            }
            else
            {
                return "Postać nie żyję";
            }
        }
        public void BijWroga(Bohater postac)
        {
            if (postac.Hp > 0)
            {
                postac.Hp -= Atak;
                Console.Write("{0} zaatakowała {1} i zadał mu obrażenia równe {2}\n", Nazwa, postac.Nazwa, Atak);
            }

        }

    }
}

