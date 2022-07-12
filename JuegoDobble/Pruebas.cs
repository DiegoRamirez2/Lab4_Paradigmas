/*
using System;
using System.Collections.Generic;
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
            List<String> strings = new List<String>
            {
                "1", "2", "3", "4", "5", "6", "7" 
            };
            DobbleGame dobbleGame = new DobbleGame(3, new Dobble(strings, 3, 7), "StackMode");
            string[] Dobble = dobbleGame.ToString().Split('\n');
            foreach(string str in Dobble)
            {
                Console.WriteLine(str);
            }
        }
    }
}
*/