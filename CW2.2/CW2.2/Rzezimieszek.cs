using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2._2
{
    class Rzezimieszek : Bohater
    {
        public int Energia;

        public Rzezimieszek(string nazwa, int hp, int atak, Rasa rasa, int energia) : base(nazwa, hp, atak, rasa)
        {
            Energia = energia;
        }
    }
}