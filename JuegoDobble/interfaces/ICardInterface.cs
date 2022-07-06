using model;
using System;

namespace interfaces
{
    public interface ICardInterface
    {
        Card GetCarta();
        String ToString();
        bool Equals(object o);
    }
}