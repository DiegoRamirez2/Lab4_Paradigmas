using model;
using System;
using System.Collections.Generic;

namespace interfaces
{
    public interface ICardInterface
    {
        Card GetCarta();
        String ToString();
        bool Equals(object o);
        List<String> CardIntersect(Card C);
        int GetHashCode();
    }
}