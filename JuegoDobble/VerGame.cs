using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace JuegoDobble
{
    public partial class VerGame : Form
    {
        public VerGame()
        {
            InitializeComponent();
        }
        private void VerGame_Load(object sender, EventArgs e)
        {
            AgregarPlayers();
            AgregarCartas();
            AgregarElementos();
            mPlayers.Items.Add(MainMenu.Game.NumPlayers);
            Gmode.Items.Add(MainMenu.Game.GameMode);
        }
        private void AgregarPlayers()
        {
            if(MainMenu.Game.ListPlayers.Count == 0)
            {
                Players.Items.Add("No hay jugadores registrados");
            }
            else
            {
                foreach (Player P in MainMenu.Game.ListPlayers)
                {
                    Players.Items.Add(P.GetUsername());
                }
            }
        }
        private void AgregarCartas()
        {
            for(int i = 0; i < MainMenu.Game.DobbleSet.cardsSet.Count; i++)
            {
                String carta = "Carta N°" + (i + 1) + ": " + MainMenu.Game.DobbleSet.cardsSet[i].ToString();
                Cards.Items.Add(carta);
            }
        }
        private void AgregarElementos()
        {
            foreach(String S in MainMenu.Game.DobbleSet.elements) 
            {
                    Elements.Items.Add(S);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
