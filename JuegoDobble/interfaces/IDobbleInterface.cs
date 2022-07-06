using System.Collections;
using System;

namespace interfaces
{
    public interface IDobbleInterface
    {
        ArrayList SetConstructor(ArrayList E, int Num, int C);
        bool IsDobble();
        ArrayList MissingCards();
        void AddCard(int Pos);
        ArrayList GetCardsSet();
        ArrayList GetElements();
        String ToString();
        bool Equals(object o);
    }
}