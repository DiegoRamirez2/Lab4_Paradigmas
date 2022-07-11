using interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class Dobble : IDobbleInterface
    {

        public List<Card> cardsSet;

        public List<String> elements;

        public Dobble(List<String> elementos, int numE, int maxC)
        {
            this.cardsSet = Shuffle(SetConstructor(elementos, numE, maxC));
            this.elements = elementos;


        }

        public List<Card> SetConstructor(List<String> ListaE, int numE, int maxC)
        {
            int n = (numE - 1);
            Card newCard = new Card();
            List<Card> Cartas = new List<Card>();
            for (int i = 1; i <= n + 1; i++)
            {
                newCard.Add(ListaE[i - 1]);
            }

            Cartas.Add(newCard);
            for (int j = 1; (j <= n); j++)
            {
                Card newCard2 = new Card
                {
                    ListaE[0]
                };
                for (int k = 1; (k <= n); k++)
                {
                    int valor = ((n * j)
                                + (k + 1));
                    newCard2.Add(ListaE[valor - 1]);
                }

                Cartas.Add(newCard2);
            }

            for (int i = 1; (i <= n); i++)
            {
                for (int j = 1; (j <= n); j++)
                {
                    Card newCard3 = new Card
                    {
                        ListaE[i]
                    };
                    for (int k = 1; (k <= n); k++)
                    {
                        int valor = (n + (2 + ((n * (k - 1)) + ((((i - 1) * (k - 1)) + (j - 1)) % n))));
                        newCard3.Add(ListaE[valor - 1]);
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
                List<Card> subCartas = new List<Card>();
                for (int i = 0; (i < maxC); i++)
                {
                    subCartas.Add(Cartas[i]);
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
                    List<String> aux3 = aux1.CardIntersect(aux2);
                    if (aux3.Count != 1)
                    {
                        return false;
                    }

                }

            }
            return true;
        }

        public List<Card> MissingCards()
        {
            Card firstCard = (Card)this.cardsSet[0];
            List<Card> aux = this.SetConstructor(this.elements, firstCard.Count, -1);
            return CardsSubstract(aux);
        }

        public void AddCard(Card C1)
        {
            this.cardsSet.Add(C1);
        }

        public List<Card> GetCardsSet()
        {
            return this.cardsSet;
        }

        public List<String> GetElements()
        {
            return this.elements;
        }

        public List<Card> CardsSubstract(List<Card> CS)
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
        public List<Card> Shuffle(List<Card> Lista)
        {
            var rnd = new Random();
            return Lista.OrderBy(item => rnd.Next()).ToList();
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
            for (int j = 0; j < this.elements.Count; j++)
            {
                if (j == elements.Count - 1)
                {
                    elementos.Append((String)elements[j]);
                    elementos.Append("]");
                }
                else
                {
                    elementos.Append((String)elements[j]).Append(", ");
                }
            }
            return "El cardsSet es: \n" + cadena + "La lista de elementos usados es: " + elementos + "\n";
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
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Card>>.Default.GetHashCode(cardsSet);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(elements);
            return hashCode;
        }
    }
}
