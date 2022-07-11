using model;
using System;
using System.Windows.Forms;
namespace JuegoDobble
{
    public partial class MainMenu : Form
    {
        public static DobbleGame Game;
        public MainMenu()
        {
            Game = null;
            InitializeComponent();
        }
        private void Crear_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (CreateGame ventanaCreateGame = new CreateGame())
                ventanaCreateGame.ShowDialog();
            this.Show();
            correctGame.SetError(RegisterBtn, "");
            correctGame.SetError(SeeGamebtn, "");
            correctGame.SetError(PlayBtn, "");

        }
        public void Registrar_Click(object sender, EventArgs e)
        {
            if (Game == null)
            {
                correctGame.SetError(RegisterBtn, "No hay un juego creado para registrar jugadores");
            }
            else if (!(MainMenu.Game.ListPlayers.Count < MainMenu.Game.NumPlayers))
            {
                correctGame.SetError(RegisterBtn, "No se pueden registrar más jugadores");
            }
            else
            {
                this.Hide();
                using (RegistrarMenu ventanaRegistrar = new RegistrarMenu())
                    ventanaRegistrar.ShowDialog();
                this.Show();
                correctGame.SetError(RegisterBtn, "");
                correctGame.SetError(PlayBtn, "");
                correctGame.SetError(SeeGamebtn, "");
            }

        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeeGamebtn_Click(object sender, EventArgs e)
        {
            if (Game == null)
            {
                correctGame.SetError(SeeGamebtn, "No hay un juego creado para ver el estado completo");
            }
            else
            {
                this.Hide();
                using (VerGame ventanaVer = new VerGame())
                    ventanaVer.ShowDialog();
                this.Show();
                correctGame.SetError(SeeGamebtn, "");
                correctGame.SetError(RegisterBtn, "");
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (Game == null)
            {
                correctGame.SetError(PlayBtn, "No hay un juego creado para jugar");
            }
            else if (Game.ListPlayers.Count <= 1)
            {
                correctGame.SetError(PlayBtn, "No existen suficientes jugadores para jugar");
            }
            else if (Game.Status() == "Terminado")
            {
                correctGame.SetError(PlayBtn, "El juego actual se encuentra terminado, debe crear otro para poder jugar");
            }
            else
            {
                this.Hide();
                using (PlayMenu ventanaPlay = new PlayMenu(Game))
                    ventanaPlay.ShowDialog();
                this.Show();
                correctGame.SetError(PlayBtn, "");
            }
        }
    }
}
