using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using interfaces;
using System.Windows.Forms;
using model;

namespace model
{
    public class DobbleGame : IDobbleGameInterface
    {

        public Dobble DobbleSet;

        public int NumPlayers;

        public ArrayList ListPlayers;

        public String GameMode;

        public String GameStatus;

        public ArrayList GameArea;

        public DobbleGame(int NPlayers, Dobble cardsSet, String GM)
        {
            NumPlayers = NPlayers;
            this.ListPlayers = new ArrayList();
            this.DobbleSet = cardsSet;
            this.GameMode = GM;
            this.GameStatus = "Jugando";
            this.GameArea = new ArrayList();
        }

        public String Status()
        {
            return this.GameStatus;
        }

        public void StackMode()
        {
            Console.WriteLine("Estamos en Stack");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Entramos al ciclo");
                Card aux = (Card) this.DobbleSet.cardsSet[0];
                this.DobbleSet.cardsSet.RemoveAt(0);
                this.GameArea.Add(aux);
            }

        }

        public void Register(Player User)
        {
            if (this.ListPlayers.Count != 0)
            {
                foreach (Player aux in this.ListPlayers)
                {
                    if (User.Equals(aux))
                    {
                        return;
                    }

                }

            }

            if (this.ListPlayers.Count < this.NumPlayers)
            {
                this.ListPlayers.Add(User);
            }

        }

        public Player WhoseTurnsIsIt()
        {
            return (Player)this.ListPlayers[0];
        }

        public int Score(String UserName)
        {
            if ((this.ListPlayers.Count != 0))
            {
                foreach (Player aux in this.ListPlayers)
                {
                    if (String.Equals(aux.Username, UserName, StringComparison.OrdinalIgnoreCase))
                    {
                        return aux.ObtainPoint();
                    }

                }

            }

            return 0;
        }

        public void AppendPoints()
        {
            Player aux = (Player)this.ListPlayers[0];
            aux.Cartas.AddRange(this.GameArea);
            this.GameArea.Clear();
        }

        public void Null()
        {
            if (String.Equals(this.GameMode, "stackmode", System.StringComparison.OrdinalIgnoreCase))
            {
                this.StackMode();
            }

        }

        public void SpotIt(String Elemento)
        {
            Card aux = new Card();
            Card aux2 = new Card();
            aux.AddRange((Card)this.GameArea[0]);
            aux2.AddRange((Card)this.GameArea[1]);
            Card aux3 = aux.CardIntersect(aux2);
            if (aux3.Count == 1 && String.Equals((String)aux3[0], Elemento, StringComparison.OrdinalIgnoreCase))
            {
                this.AppendPoints();
                this.GameArea.Clear();
            }

            this.NextTurn();
        }

        public void Pass()
        {
            if ((this.GameArea.Count < 2))
            {
                this.NextTurn();
            }
            else
            {
                this.DobbleSet.cardsSet.Insert(0, this.GameArea[1]);
                this.DobbleSet.cardsSet.Insert(0, this.GameArea[0]);
                this.GameArea.Clear();
                this.NextTurn();
            }
        }

        public void Finish()
        {
            this.GameStatus = "Terminado";
        }

        public void NextTurn()
        {
            Player player = (Player)this.ListPlayers[0];
            this.ListPlayers.RemoveAt(0);
            this.ListPlayers.Add(player);
        }

        public String Puntajes()
        {
            StringBuilder cadena = new StringBuilder();
            foreach (Player listPlayer in this.ListPlayers)
            {
                cadena.Append(listPlayer.GetUsername()).Append(" tiene: ").Append(listPlayer.ObtainPoint()).Append(" puntos\n");
            }

            return ("### Lista de puntajes ###\n" + cadena);
        }

        public String Resultado()
        {
            if ((this.ListPlayers.Count > 0))
            {
                this.ListPlayers.Sort();
                StringBuilder cadena = new StringBuilder();
                Player FirstUser = (Player)this.ListPlayers[0];
                cadena.Append(FirstUser.PlayerAndPoints()).Append("\n### Perdedor(es) ###\n");
                for (int i = 1; (i < this.ListPlayers.Count); i++)
                {
                    Player iUser = (Player)this.ListPlayers[i];
                    cadena.Append(iUser.PlayerAndPoints()).Append("\n");
                }

                return ("### Ganador ###\n" + cadena);
            }

            return "No existen jugadores en el juego";
        }

        public Dobble GetDobbleSet()
        {
            return this.DobbleSet;
        }

        public ArrayList GetListPlayers()
        {
            return this.ListPlayers;
        }

        public String GetGameMode()
        {
            return this.GameMode;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < ListPlayers.Count; i++)
            {
                if(i == ListPlayers.Count - 1)
                {
                    sb.Append(ListPlayers[i]);
                }
                else
                {
                    sb.Append(ListPlayers[i] + ", ");
                }
            }
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < GameArea.Count; i++)
            {
                if (i == GameArea.Count - 1)
                {
                    sb2.Append(GameArea[i]);
                }
                else
                {
                    sb2.Append(GameArea[i] + ", ");
                }
            }
            return this.DobbleSet + "Numero de jugadores: "
                        + this.NumPlayers + "\nLista de Jugadores registrados: ["
                        + sb + "]\nModo de Juego: "
                        + this.GameMode + "\nEstado del Juego: "
                        + this.GameStatus + "\nArea de Juego: ["
                        + sb2 + "]\n";
        }

        public override bool Equals(Object DBG1)
        {
            if ((this == DBG1))
            {
                return true;
            }

            if ((DBG1 == null))
            {
                return false;
            }

            if (DBG1.GetType() != this.GetType())
            {
                return false;
            }

            DobbleGame newDBG = ((DobbleGame)(DBG1));
            return (newDBG.GetDobbleSet().Equals(this.DobbleSet)
                        && (newDBG.GetListPlayers().Equals(this.ListPlayers) && newDBG.GetGameMode().Equals(this.GameMode)));
        }

        public override int GetHashCode()
        {
            int hashCode = -1156308396;
            hashCode = hashCode * -1521134295 + EqualityComparer<Dobble>.Default.GetHashCode(DobbleSet);
            hashCode = hashCode * -1521134295 + NumPlayers.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ArrayList>.Default.GetHashCode(ListPlayers);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameStatus);
            hashCode = hashCode * -1521134295 + EqualityComparer<ArrayList>.Default.GetHashCode(GameArea);
            return hashCode;
        }
    }
}
