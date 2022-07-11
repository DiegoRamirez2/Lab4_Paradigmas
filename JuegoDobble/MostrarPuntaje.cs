using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JuegoDobble
{
    public partial class MostrarPuntaje : Form
    {
        private String Imprimir;
        public MostrarPuntaje(String S)
        {
            Imprimir = S;
            InitializeComponent();
        }

        private void MostrarPuntaje_Load(object sender, EventArgs e)
        {
            GenerateList();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GenerateList()
        {
            List<String> list = Imprimir.Split('\n').ToList();
            foreach (String sb in list)
            {
                Puntajes.Items.Add(sb);
            }
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
    }
}
