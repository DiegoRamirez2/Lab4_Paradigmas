using System;
using System.Collections;
using System.Collections.Generic;
using interfaces;
using System.Text;
using System.Linq;

namespace model
{
    public class Card : ArrayList, ICardInterface
    {

        public ArrayList carta;

        //  Metodos
        //  Constructor
        public Card()
        {
            this.carta = new ArrayList();
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
                Card aux = (Card)C1;
                Card aux2 = CardIntersect(aux);
                return aux2.Count == this.carta.Count;
            }
        }
        public Card CardIntersect(Card C2)
        {
            Card C1 = new Card();
            for (int i = 0; i < C2.Count; i++)
            {
                if (this.carta.Contains((String) C2[i]))
                {
                    C1.carta.Add((String) C2[i]);
                }
            }
            return C1;
        }

        public override int GetHashCode()
        {
            int hashCode = -1768568329;
            hashCode = hashCode * -1521134295 + Capacity.GetHashCode();
            hashCode = hashCode * -1521134295 + Count.GetHashCode();
            hashCode = hashCode * -1521134295 + IsFixedSize.GetHashCode();
            hashCode = hashCode * -1521134295 + IsReadOnly.GetHashCode();
            hashCode = hashCode * -1521134295 + IsSynchronized.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(SyncRoot);
            hashCode = hashCode * -1521134295 + EqualityComparer<ArrayList>.Default.GetHashCode(carta);
            return hashCode;
        }
    }
}