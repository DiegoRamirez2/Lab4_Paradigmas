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
    public partial class RegistrarMenu : Form
    {
        public RegistrarMenu()
        {
            InitializeComponent();
        }
        private void RegistrarMenu_Load(object sender, EventArgs e)
        {
            RegisterBtn.Enabled = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            ControlRegister();
        }
        private void ControlRegister()
        {
            Player P1 = new Player((String)Usuario.Text);
            if (IsRegister(P1))
            {
                RegisterBtn.Enabled = false;
                notRegister.SetError(Usuario, "El usuario ya se encuentra registrado");
            }
            else if (!(MainMenu.Game.ListPlayers.Count < MainMenu.Game.NumPlayers))
            {
                RegisterBtn.Enabled = false;
                notRegister.SetError(Usuario, "No se pueden registrar más jugadores");
            }
            else if (Usuario.Text.Trim() == String.Empty)
            {
                RegisterBtn.Enabled = false;
                notRegister.SetError(Usuario, "Debe introducir el nombre de usuario");
            }
            else
            {
                RegisterBtn.Enabled = true;
                notRegister.SetError(Usuario, "");
            }

        }
        private Boolean IsRegister(Player P)
        {
            foreach (Player aux in MainMenu.Game.ListPlayers)
            {
                if (P.Equals(aux))
                {
                    return true;
                }
            }
            return false;
        }
        private void Register()
        {
            MainMenu.Game.Register(new Player(Usuario.Text));
            MessageBox.Show("Usuario registrado corrrectamente");
            RegisterBtn.Enabled = false;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            ControlRegister();
            Register();
        }

        private void Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (RegisterBtn.Enabled != false)
                {
                    ControlRegister();
                    Register();   
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    } 
}
