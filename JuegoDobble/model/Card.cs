using System;
using System.Collections;
using System.Collections.Generic;
using interfaces;
using System.Text;
using System.Linq;

namespace model
{
    public class Card : List<String>, ICardInterface
    {

        public List<String> carta;

        //  Metodos
        //  Constructor
        public Card()
        {
            this.carta = new List<String>();
        }

        public Card GetCarta()
        {
            return this;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < this.Count; j++)
            {
                if (j == this.Count - 1)
                {
                    sb.Append(this[j]);
                    sb.Append("]");
                }
                else
                {
                    sb.Append(this[j]).Append(", ");
                }
            }
            return "[" + sb;
        }

        public override bool Equals(object C1)
        {
            if ((this == C1))
            {
                return true;
            }

            if ((C1 == null))
            {
                return false;
            }
            if (C1.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Card aux = (Card) C1;
                IEnumerable<String> list = aux.Intersect(this.carta);
                return list.Count() == this.carta.Count;
            }
        }
        public List<String> CardIntersect(Card C2)
        {
            List<String> list1 = new List<String>();
            foreach(String S in this)
            {
                list1.Add(S);
            }
            List<String> list2 = new List<String>();
            foreach(String S in C2)
            {
                list2.Add(S);
            }
            return list1.Intersect(list2).ToList();
        }
        public override int GetHashCode()
        {
            int hashCode = 461492247;
            hashCode = hashCode * -1521134295 + Capacity.GetHashCode();
            hashCode = hashCode * -1521134295 + Count.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(carta);
            return hashCode;
        }
    }
}