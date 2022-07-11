using System;
using System.Collections;
using System.Text;
using interfaces;
using model;
using System.Diagnostics;
using System.Collections.Generic;

namespace model
{
    public class Dobble : IDobbleInterface
    {

        public ArrayList cardsSet;

        public ArrayList elements;

        public Dobble(ArrayList elementos, int numE, int maxC)
        {
            this.cardsSet = this.SetConstructor(elementos, numE, maxC);
            this.elements = elementos;
            

        }

        public ArrayList SetConstructor(ArrayList ListaE, int numE, int maxC)
        {
            int n = (numE - 1);
            Card newCard = new Card();
            ArrayList Cartas = new ArrayList();
            for (int i = 1; i <= n + 1; i++)
            {
                newCard.Add((String) ListaE[i - 1]);
            }

            Cartas.Add(newCard);
            for (int j = 1; (j <= n); j++)
            {
                Card newCard2 = new Card
                {
                    (String) ListaE[0]
                };
                for (int k = 1; (k <= n); k++)
                {
                    int valor = ((n * j)
                                + (k + 1));
                    newCard2.Add((String) ListaE[valor - 1]);
                }

                Cartas.Add(newCard2);
            }

            for (int i = 1; (i <= n); i++)
            {
                for (int j = 1; (j <= n); j++)
                {
                    Card newCard3 = new Card
                    {
                        (String) ListaE[i]
                    };
                    for (int k = 1; (k <= n); k++)
                    {
                        int valor = (n + (2+ ((n * (k - 1)) + ((((i - 1) * (k - 1)) + (j - 1)) % n))));
                        newCard3.Add((String) ListaE[valor - 1]);
                    }

                    Cartas.Add(newCard3);
                }

            }

            if ((maxC <= 0))
            {
                return Cartas;
            }
            else
            {
                ArrayList subCartas = new ArrayList();
                for (int i = 0; (i < maxC); i++)
                {
                    subCartas.Add((Card)Cartas[i]);
                }

                return subCartas;
            }

        }

        public bool IsDobble()
        {
            Card firstCard = (Card)this.cardsSet[0];
            for (int i = 1; i < this.cardsSet.Count; i++)
            {
                Card nextCard = (Card)this.cardsSet[i];
                if (firstCard.Count != nextCard.Count)
                {
                    return false;
                }

            }

            foreach (Card iCard in this.cardsSet)
            {
                for (int j = 0; j < iCard.Count; j++)
                {
                    for (int k = j + 1; k < iCard.Count; k++)
                    {
                        if (iCard[k] == iCard[j])
                        {
                            return false;
                        }

                    }

                }

            }
            for (int i = 0; i < (this.cardsSet.Count - 1); i++)
            {
                for (int j = (i + 1); j < this.cardsSet.Count; j++)
                {
                    Card aux1 = (Card)this.cardsSet[i];
                    Card aux2 = (Card)this.cardsSet[j];
                    Card aux3 = aux1.CardIntersect(aux2);
                    if (aux3.Count != 1)
                    {
                        return false;
                    }

                }

            }

            return true;
        }

        public ArrayList MissingCards()
        {
            Card firstCard = (Card)this.cardsSet[0];
            ArrayList aux = this.SetConstructor(this.elements, firstCard.Count, -1);
            return CardsSubstract(aux);
        }

        public void AddCard(int Pos)
        {
            this.cardsSet.Add((Card)this.MissingCards()[Pos]);
        }

        public ArrayList GetCardsSet()
        {
            return this.cardsSet;
        }

        public ArrayList GetElements()
        {
            return this.elements;
        }

        public ArrayList CardsSubstract(ArrayList CS)
        {
            for (int i = 0; i < this.cardsSet.Count; i++)
            {
                if (CS.Contains((Card)this.cardsSet[i]))
                {
                    CS.Remove((Card)this.cardsSet[i]);
                }
            }
            return CS;
        }

        public override String ToString()
        {
            StringBuilder cadena = new StringBuilder();
            StringBuilder elementos = new StringBuilder();
            for (int i = 0; i < this.cardsSet.Count; i++)
            {
                cadena.Append("Carta N° ").Append(i + 1).Append(": ").Append(this.cardsSet[i]).Append("\n");
            }
            elementos.Append("[");
            for(int j = 0; j < this.elements.Count; j++)
            {
                if(j == elements.Count - 1)
                {
                    elementos.Append((String)elements[j]);
                    elementos.Append("]");
                }
                else
                {
                    elementos.Append((String)elements[j]).Append(", ");
                }
            }
            return "El cardsSet es: \n" + cadena + "La lista de elementos usados es: "+ elementos + "\n";
        }

        public override bool Equals(Object DB1)
        {
            if ((this == DB1))
            {
                return true;
            }

            if ((DB1 == null))
            {
                return false;
            }

            if (DB1.GetType() != this.GetType())
            {
                return false;
            }
            Dobble newDobble = ((Dobble)(DB1));
            return (newDobble.GetCardsSet().Equals(this.cardsSet) && newDobble.GetElements().Equals(this.elements));
        }

        public override int GetHashCode()
        {
            int hashCode = 1777670008;
            hashCode = hashCode * -1521134295 + EqualityComparer<ArrayList>.Default.GetHashCode(cardsSet);
            hashCode = hashCode * -1521134295 + EqualityComparer<ArrayList>.Default.GetHashCode(elements);
            return hashCode;
        }
    }
}
