using System;
using System.Windows.Forms;
using model;
using System.Collections.Generic;
namespace JuegoDobble
{
    public partial class AddCards : Form
    {
        public List<Card> MissingC;
        public AddCards(List<Card> Cards)
        {
            MissingC = Cards;
            InitializeComponent();
        }

        private void AddCards_Load(object sender, EventArgs e)
        {
            getNumMissing();
            MissingLabel.Text = MissingLabel.Text + MissingC.Count + "cartas";
        }
        private void getNumMissing()
        {
            for(int i = 1; i <= MissingC.Count; i++)
            {
                NumMissing.Items.Add(i);
            }
        }
        private void AddMissing()
        {
            for(int i = 0; i < (int) NumMissing.SelectedItem; i++)
            {
                PlayMenu.Game.DobbleSet.AddCard(MissingC[i]);
            }
        }

        private void NullBtn_Click(object sender, EventArgs e)
        {
            AddMissing();
            MessageBox.Show("Las cartas se han agregado correctamente");
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
