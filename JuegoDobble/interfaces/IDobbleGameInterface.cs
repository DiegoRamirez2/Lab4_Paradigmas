using System;
using model;
using System.Collections;

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
        ArrayList GetListPlayers();
        String GetGameMode();
        String ToString();
        bool Equals(object o);
        int GetHashCode();
    }
}