using System;
using model;
using System.Collections;
using System.Collections.Generic;

namespace interfaces
{
    public interface IDobbleGameInterface
    {
        String Status();
        void StackMode();
        void Register(Player U);
        Player WhoseTurnsIsIt();
        void AppendPoints();
        void Null();
        void SpotIt(String Elemento);
        void Pass();
        void Finish();
        void NextTurn();
        String Puntajes();
        String Resultado();
        Dobble GetDobbleSet();
        List<Player> GetListPlayers();
        String GetGameMode();
        String ToString();
        bool Equals(object o);
        int GetHashCode();
    }
}