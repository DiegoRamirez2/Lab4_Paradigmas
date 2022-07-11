using System;
using model;
using System.Collections;
public interface IPlayerInterface {
    int ObtainPoint();
    String ToString();
    String PlayerAndPoints();
    String GetUsername();
    int CompareTo(Player P);
    bool Equals(Object o);
    int GetHashCode();
}