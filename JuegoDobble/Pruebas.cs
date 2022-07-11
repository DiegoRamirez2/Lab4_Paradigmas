
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace JuegoDobble
{
    class Pruebas
    {
        static void Main(string[] args)
        {
            ArrayList set1 = new ArrayList
            {
                "1", "2", "3", "4", "5", "6", "7"
            };
            Dobble DobbleNew = new Dobble(set1, 3, -1);
            DobbleGame DobbleG = new DobbleGame(4, DobbleNew, "stackmode");
            Player P1 = new Player("Diego");
            DobbleG.Register(P1);
            Player P2 = new Player("Ale");
            DobbleG.Register(P2);
            Player P3 = new Player("Mel");
            DobbleG.Register(P3);
            DobbleG.Null();
            Console.WriteLine(DobbleG.ToString());
            DobbleG.SpotIt("1");
            Card aux = (Card) DobbleG.GameArea[0];
            Card aux1 = (Card) DobbleG.GameArea[1];
            Console.WriteLine(aux1.ToString());
            Console.WriteLine(aux.ToString());
        }
    }
}
