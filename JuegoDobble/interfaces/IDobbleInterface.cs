using System.Collections;
using System;
using model;
using System.Collections.Generic;

namespace interfaces
{
    public interface IDobbleInterface
    {
        List<Card> SetConstructor(List<String> E, int Num, int C);
        bool IsDobble();
        List<Card> MissingCards();
        void AddCard(Card C1);
        List<Card> GetCardsSet();
        List<String> GetElements();
        List<Card> CardsSubstract(List<Card> cards);
        List<Card> Shuffle(List<Card> cards);
        String ToString();
        bool Equals(object o);
        int GetHashCode();
    }
}