/*
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
            List<String> set1 = new List<String>
            {
                "1", "2", "3", "4", "5", "6", "7"
            };
            List<String> set2 = new List<String>
            {
                "1", "2", "3"
            };
            List<String> set3 = new List<String>
            {
                "1", "4", "5"
            };
            Dobble DobbleNew = new Dobble(set1, 3, 3);
            DobbleGame DobbleG = new DobbleGame(4, DobbleNew, "stackmode");
            Player P1 = new Player("Diego");
            DobbleG.Register(P1);
            Player P2 = new Player("Ale");
            DobbleG.Register(P2);
            Player P3 = new Player("Mel");
            DobbleG.Register(P3);
            Console.WriteLine(DobbleG.ToString());
            List<Card> aux = DobbleG.DobbleSet.MissingCards();
            foreach(Card card in aux)
            {
                Console.WriteLine(card.ToString());
            }

        }
    }
}
*/