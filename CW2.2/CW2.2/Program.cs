using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rzezimieszek DP1 = new Rzezimieszek("Yasuo", 200, 40, Bohater.Rasa.Wojownik, 40);
            Mag DP2 = new Mag("Veigar", 70, 30, Bohater.Rasa.Czlowiek, 80);
            Wojownik DP3 = new Wojownik("Zed", 130, 40, Bohater.Rasa.Czlowiek);

            Rzezimieszek U1 = new Rzezimieszek("Diana", 50, 10, Bohater.Rasa.Mag, 20);
            Mag U2 = new Mag("Ahri", 80, 30, Bohater.Rasa.Mag, 100);
            Wojownik U3 = new Wojownik("Galio", 60, 40, Bohater.Rasa.Mag);


            List<Bohater> Drużyna_Pierścienia = new List<Bohater>();

            Drużyna_Pierścienia.Add(DP1);
            Drużyna_Pierścienia.Add(DP2);
            Drużyna_Pierścienia.Add(DP3);

            List<Bohater> Uruk_hai = new List<Bohater>();

            Uruk_hai.Add(U1);
            Uruk_hai.Add(U2);
            Uruk_hai.Add(U3);
            Random random = new Random(DateTime.Now.Millisecond);

            foreach (var postac in Drużyna_Pierścienia)
            {
                foreach (var enemy in Uruk_hai)
                {
                    if (enemy.Hp>0)
                    {
                        postac.BijWroga(enemy);
                        Console.WriteLine(enemy.SprawdzHp());
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
