using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using interfaces;
using model;

namespace model
{
    public class Player : IPlayerInterface, IComparable<Player>
    {

        public String Username;

        public List<Card> Cartas;

        public Player(String User)
        {
            this.Username = User;
            this.Cartas = new List<Card>();
        }

        public int ObtainPoint()
        {
            return this.Cartas.Count;
        }

        public override String ToString()
        {
            return this.Username + "";
        }

                public String PlayerAndPoints()
        {
            return (this.Username + ": " + this.ObtainPoint() + " puntos");
        }

        public String GetUsername()
        {
            return this.Username;
        }

        public override bool Equals(Object P1)
        {
            if ((this == P1))
            {
                return true;
            }

            if ((P1 == null))
            {
                return false;
            }

            if (P1.GetType() != this.GetType()) 
            {
            return false;
            }
            Player jugador = ((Player)(P1));

            return String.Equals(jugador.GetUsername(), this.Username, StringComparison.OrdinalIgnoreCase);
        }
        public int CompareTo(Player Jugador)
        {
            if(this.ObtainPoint() < Jugador.ObtainPoint())
            {
                return 1;
            }
            else if(this.ObtainPoint() > Jugador.ObtainPoint()) {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = -1078345092;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Card>>.Default.GetHashCode(Cartas);
            return hashCode;
        }
    }
}