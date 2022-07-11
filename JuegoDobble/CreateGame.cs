using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JuegoDobble
{
    public partial class CreateGame : Form
    {
        public int[] numElements = { 2, 3, 4, 8, 12, 14};
        public String[] Modes = { "StackMode" };
        public CreateGame()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateGame_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            AddGameMode();
            AddNumE();
        }
        private void AddGameMode()
        {
            for (int i = 0; i < Modes.Length; i++)
            {
                Modo.Items.Add(Modes[i]);
            }
        }
        private void AddNumE()
        {
            foreach (int I in numElements)
            {
                numE.Items.Add(I);
            }
        }
        private List<int> AddCards(int numE)
        {
            int GmaxC = numE * numE + numE + 1;
            List<int> ints = new List<int>();
            for (int i = 2; i <= GmaxC; i++)
            {
                ints.Add(i);
            }
            return ints;
        }
        private void Crear_Click(object sender, EventArgs e)
        {
            switch (Validacion())
            {
                case 0:
                    {
                        errorProvider2.SetError(CardPlayer, "");
                        errorProvider2.SetError(CardMode, "");
                        errorProvider2.SetError(panel1, "");
                        MainMenu.Game = CrearJuego();
                        MessageBox.Show("¡Se ha creado el juego con éxito!");
                        this.Close();
                        break;
                    }
                case 1:
                    {
                        errorProvider2.SetError(CardPlayer, "Debe completar los datos de simbolos e ingresar un valor númerico");
                        errorProvider2.SetError(CardMode, "");
                        errorProvider2.SetError(panel1, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider2.SetError(CardPlayer, "");
                        errorProvider2.SetError(CardMode, "Debe completar los datos de número de cartas y modo de juego");
                        errorProvider2.SetError(panel1, "");
                        break;
                    }
                case 3:
                    {
                        errorProvider2.SetError(CardPlayer, "");
                        errorProvider2.SetError(CardMode, "");
                        errorProvider2.SetError(panel1, "Faltan elementos por agregar");
                        break;
                    }
                case 4:
                    {
                        errorProvider2.SetError(CardPlayer, "Debe ser más de 1 jugador");
                        errorProvider2.SetError(CardMode, "");
                        errorProvider2.SetError(panel1, "");
                        break;
                    }


            }
        }
        private int Validacion()
        {
            if (numE.SelectedIndex <= -1 || !NumP.Text.All(Char.IsDigit) || NumP.Text == "")
            {
                return 1;
            }
            else
            {
                if (comboBox2.SelectedIndex <= -1 || Modo.SelectedIndex <= -1)
                {
                    return 2;
                }
                else
                {
                    int aux = (int)numE.SelectedItem - 1;
                    if (ListElem.Items.Count != (aux * aux + aux + 1))
                    {
                        return 3;
                    }
                    else if(Convert.ToInt16(NumP.Text) <= 1)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        private DobbleGame CrearJuego()
        {
            int GmaxC = (int)comboBox2.SelectedItem;
            int GnumE = (int)numE.SelectedItem;
            AddCards(GnumE);
            List<String> SimbolsAL = new List<String>();
            foreach (String S in ListElem.Items)
            {
                SimbolsAL.Add(S);
            }
            int GNumP = Convert.ToInt16(NumP.Text);
            String GModo = (String)Modo.SelectedItem;
            DobbleGame G1 = new DobbleGame(GNumP, new Dobble(SimbolsAL, GnumE, GmaxC), GModo);
            return G1;
        }

        private void AgregarE_Click(object sender, EventArgs e)
        {
            AddElement();
        }
        private void AddElement()
        {
            if (!(numE.SelectedIndex <= -1))
            {
                int aux = (int)numE.SelectedItem - 1;
                if ((aux * aux + aux + 1) <= ListElem.Items.Count)
                {
                    errorProvider2.SetError(Elem, "No puede ingresar más elementos");
                }
                else
                {
                    if (Elem.Text.Trim() == String.Empty)
                    {
                        errorProvider2.SetError(Elem, "No puede ingresar texto vacío");
                    }
                    else if (ListElem.FindString(Elem.Text) != -1)
                    {
                        errorProvider2.SetError(Elem, "El elemento ya ha sido agregado");
                    }
                    else
                    {
                        errorProvider2.SetError(Elem, "");
                        ListElem.Items.Add(Elem.Text);
                        Elem.Text = String.Empty;
                        ActualizarLabel();
                    }
                }
            }

        }
        private void numE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(numE.SelectedIndex <= -1))
            {
                errorProvider2.SetError(panel1, "");
                int aux = (int)numE.SelectedItem - 1;
                comboBox2.Enabled = true;
                comboBox2.DataSource = AddCards((int)numE.SelectedItem - 1);
                while ((aux * aux + aux + 1) < ListElem.Items.Count)
                {
                    ListElem.Items.RemoveAt(ListElem.Items.Count - 1);
                }
                ActualizarLabel();
            }
        }
        private void Elem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddElement();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ListElem.Items.Clear();
            errorProvider2.SetError(Elem, "");
            ActualizarLabel();
            this.FillBtn.Enabled = true;
        }
        private void ActualizarLabel()
        {
            int aux = (int)numE.SelectedItem - 1;
            cantidadE.Text = " Faltan por ingresar:";
            Num.Text = "   " + Convert.ToString(aux * aux + aux + 1 - ListElem.Items.Count);
        }
        private void FillBtn_Click(object sender, EventArgs e)
        {
            if(!(numE.SelectedIndex <= -1))
            {
                errorProvider2.SetError(panel1, "");
                int aux = (int)numE.SelectedItem - 1;
                int aux1 = ListElem.Items.Count;
                int i = 1;
                while (i <= (aux * aux + aux + 1) - aux1)
                {
                    ListElem.Items.Add(Convert.ToString(i));
                    i++;
                }
                ActualizarLabel();
                this.FillBtn.Enabled = false;
            }
            else
            {
                errorProvider2.SetError(panel1, "Debe elegir el número de símbolos");
            }
        }
    }
}
