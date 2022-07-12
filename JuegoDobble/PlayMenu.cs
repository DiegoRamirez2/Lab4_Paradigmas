using model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoDobble
{
    public partial class PlayMenu : Form
    {
        public static DobbleGame Game;
        private static string Turn = "Es el turno de:";
        public PlayMenu(DobbleGame G)
        {
            Game = G;
            InitializeComponent();
        }
        private void PlayMenu_Load(object sender, EventArgs e)
        {
            IsTurn.Text = Turn + "\n" + Game.WhoseTurnsIsIt();
            Hide_All();

        }
        private void Show_Null()
        {
            PlayCards.Show();
            C_one.Show();
            C_two.Show();
            CardOne.Show();
            CardTwo.Show();
            CompararLabel.Show();
            ElemElected.Show();
            SpotItBtn.Show();
        }
        private void Hide_All()
        {
            PlayCards.Hide();
            C_one.Hide();
            C_two.Hide();
            CardOne.Hide();
            CardTwo.Hide();
            CompararLabel.Hide();
            ElemElected.Hide();
            SpotItBtn.Hide();
        }

        private void NullBtn_Click(object sender, EventArgs e)
        {
            if (Game.GameArea.Count != 0)
            {
                CorrectCards.SetError(NullBtn, "Ya existen cartas en el área de juego");
                CorrectCards.SetError(SpotItBtn, "");
                CorrectCards.SetError(AddCardsBtn, "");
            }
            else if (Game.DobbleSet.cardsSet.Count < 2)
            {
                CorrectCards.SetError(NullBtn, "No existen suficientes cartas para voltear");
                CorrectCards.SetError(SpotItBtn, "");
                CorrectCards.SetError(AddCardsBtn, "");
            }
            else if (Game.GameArea.Count == 2)
            {
                Show_Null();
            }
            else
            {
                VaciarBoxes();
                Game.Null();
                MessageBox.Show("¡Se volteado las cartas con éxito!\nPresione el botón ¡Spot It! para realizar\nla comparación");
                AgregarElementos();
                Show_Null();
            }
        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            Game.Pass();
            MessageBox.Show("¡Se ha realizado el pase de turno con éxito!\nLas cartas han sido devueltas a su lugar");
            IsTurn.Text = String.Empty;
            IsTurn.Text = Turn + "\n" + Game.WhoseTurnsIsIt();
            Hide_All();
            VaciarBoxes();
            CorrectCards.SetError(NullBtn, "");
            CorrectCards.SetError(SpotItBtn, "");
            CorrectCards.SetError(AddCardsBtn, "");
        }
        
        private void AgregarElementos()
        {
            Card C1 = (Card)Game.GameArea[0];
            Card C2 = (Card)Game.GameArea[1];
            foreach (String S in C1)
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
                CorrectCards.SetError(NullBtn, "");
                CorrectCards.SetError(SpotItBtn, "");
                CorrectCards.SetError(AddCardsBtn, "");
                CorrectCards.SetError(ElemElected, "");
                int puntos = Game.Score(Game.WhoseTurnsIsIt().GetUsername());
                String Elemento = ElemElected.Text;
                Game.SpotIt(Elemento);
                Player P1 = (Player)Game.ListPlayers[Game.ListPlayers.Count - 1];
                if (puntos == P1.ObtainPoint())
                {
                    MessageBox.Show("¡Que lastima!, no ha acertado en su elección, " +
                        "\nAhora es el turno de: " + Game.WhoseTurnsIsIt());
                }
                else
                {
                    MessageBox.Show("¡Felicidades!, ha acertado en su elección, ha ganado 2 puntos");
                    Hide_All();
                }
                IsTurn.Text = String.Empty;
                IsTurn.Text = Turn + "\n" + Game.WhoseTurnsIsIt();
                ElemElected.Text = String.Empty;
            }
        }
        private void VaciarBoxes()
        {
            CardOne.Items.Clear();
            CardTwo.Items.Clear();
        }
        private void PointsBtn_Click(object sender, EventArgs e)
        {
            using (MostrarPuntaje ventanaPuntaje = new MostrarPuntaje(Game.Puntajes()))
                ventanaPuntaje.ShowDialog();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            using (MostrarPuntaje ventanaPuntaje = new MostrarPuntaje(Game.Resultado()))
                ventanaPuntaje.ShowDialog();
            MainMenu.Game.Finish();
            this.Close();
        }
        private void Puntajes_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left
                    + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }

        }
        private void AddCardsBtn_Click(object sender, EventArgs e)
        {
            if(Game.DobbleSet.MissingCards().Count == 0)
            {
                CorrectCards.SetError(AddCardsBtn, "No existen cartas faltantes por agregar");
            }
            else
            {
                using (AddCards ventanaAddCards = new AddCards(Game.DobbleSet.MissingCards()))
                    ventanaAddCards.ShowDialog();
            }
        }
    }
}
