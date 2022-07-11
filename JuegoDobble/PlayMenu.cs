using System;
using System.Collections;
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
    public partial class PlayMenu : Form
    {
        private DobbleGame Game;
        private static string Turn = "Es el turno de:";
        public PlayMenu(DobbleGame G)
        {
            Game = G;
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayMenu_Load(object sender, EventArgs e)
        {
            IsTurn.Text = Turn + "\n" + Game.WhoseTurnsIsIt();
            Hide_SpotIt();
            
        }
        private void Show_SpotIt()
        {
            PlayCards.Show();
            C_one.Show();
            C_two.Show();
            CardOne.Show();
            CardTwo.Show();
            CompararLabel.Show();
            ElemElected.Show();
            AcceptElem.Show();
        }
        private void Hide_SpotIt()
        {
            PlayCards.Hide();
            C_one.Hide();
            C_two.Hide();
            CardOne.Hide();
            CardTwo.Hide();
            CompararLabel.Hide();
            ElemElected.Hide();
            AcceptElem.Hide();
        }

        private void NullBtn_Click(object sender, EventArgs e)
        {
            if(Game.GameArea.Count != 0)
            {
                CorrectCards.SetError(NullBtn, "Ya existen cartas en el área de juego");
                CorrectCards.SetError(SpotItBtn, "");
                CorrectCards.SetError(AddCardsBtn, "");
            }
            else if(Game.DobbleSet.cardsSet.Count < 2)
            {
                CorrectCards.SetError(NullBtn, "No existen suficientes cartas para voltear");
                CorrectCards.SetError(SpotItBtn, "");
                CorrectCards.SetError(AddCardsBtn, "");
            }
            else
            {
                Game.Null();
                MessageBox.Show("¡Se volteado las cartas con éxito!");
            }
        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            Game.Pass();
            MessageBox.Show("¡Se ha realizado el pase de turno con éxito!\nLas cartas han sido devueltas a su lugar");
            IsTurn.Text = String.Empty;
            IsTurn.Text = Turn + "\n" + Game.WhoseTurnsIsIt();
        }

        private void SpotItBtn_Click(object sender, EventArgs e)
        {
            if(Game.GameArea.Count != 2)
            {
                CorrectCards.SetError(NullBtn, "");
                CorrectCards.SetError(SpotItBtn, "No existen cartas en el área de juego");
                CorrectCards.SetError(AddCardsBtn, "");
            }
            else
            {
                AgregarElementos();
                Show_SpotIt();
            }
        }
        private void AgregarElementos()
        {
            Card C1 = (Card)Game.GameArea[0];
            Card C2 = (Card)Game.GameArea[1];
            foreach(String S in C1)
            {
                CardOne.Items.Add(S);
            }
            foreach (String S in C2)
            {
                CardTwo.Items.Add(S);
            }
        }
        private void AcceptElem_Click(object sender, EventArgs e)
        {
            if (ElemElected.Text.Trim() == String.Empty)
            {
                CorrectCards.SetError(NullBtn, "");
                CorrectCards.SetError(SpotItBtn, "");
                CorrectCards.SetError(AddCardsBtn, "");
                CorrectCards.SetError(ElemElected, "No puede ingresar texto vacío");
            }
            else
            {
                int puntos = Game.Score(Game.WhoseTurnsIsIt().GetUsername());
                String Elemento = ElemElected.Text;
                Game.SpotIt(Elemento);
                Player P1 = (Player)Game.ListPlayers[Game.ListPlayers.Count - 1];
                if (puntos == P1.ObtainPoint())
                {
                    MessageBox.Show("¡Que lastima!, no ha acertado en su elección");
                }
                else
                {
                    MessageBox.Show("¡Felicidades!, ha acertado en su elección");
                }
            }
        }
        private void AddCard()
        {
            ArrayList aux = Game.DobbleSet.MissingCards();
            if(aux.Count == 0)
            {
                CorrectCards.SetError(AddCardsBtn, "No existen cartas faltantes");
            }
            else
            {

            }
        }
    }
}
