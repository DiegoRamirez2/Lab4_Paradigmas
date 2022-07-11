namespace JuegoDobble
{
    partial class VerGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerGame));
            this.Players = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cards = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Elements = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mPlayers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Gmode = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Players
            // 
            this.Players.BackColor = System.Drawing.Color.DarkOrange;
            this.Players.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Players.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Players.FormattingEnabled = true;
            this.Players.HorizontalScrollbar = true;
            this.Players.ItemHeight = 15;
            this.Players.Location = new System.Drawing.Point(21, 162);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(193, 64);
            this.Players.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visualización completa del Juego";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(181, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de Jugadores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de Cartas:";
            // 
            // Cards
            // 
            this.Cards.BackColor = System.Drawing.Color.DarkOrange;
            this.Cards.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Cards.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Cards.FormattingEnabled = true;
            this.Cards.HorizontalScrollbar = true;
            this.Cards.ItemHeight = 15;
            this.Cards.Location = new System.Drawing.Point(21, 264);
            this.Cards.Name = "Cards";
            this.Cards.Size = new System.Drawing.Size(212, 169);
            this.Cards.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(239, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lista de elementos \r\nusados:";
            // 
            // Elements
            // 
            this.Elements.BackColor = System.Drawing.Color.DarkOrange;
            this.Elements.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Elements.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Elements.FormattingEnabled = true;
            this.Elements.HorizontalScrollbar = true;
            this.Elements.ItemHeight = 15;
            this.Elements.Location = new System.Drawing.Point(243, 264);
            this.Elements.Name = "Elements";
            this.Elements.Size = new System.Drawing.Size(145, 64);
            this.Elements.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(239, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número máximo \r\nde jugadores:";
            // 
            // mPlayers
            // 
            this.mPlayers.BackColor = System.Drawing.Color.DarkOrange;
            this.mPlayers.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.mPlayers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mPlayers.FormattingEnabled = true;
            this.mPlayers.ItemHeight = 15;
            this.mPlayers.Location = new System.Drawing.Point(243, 193);
            this.mPlayers.Name = "mPlayers";
            this.mPlayers.Size = new System.Drawing.Size(145, 19);
            this.mPlayers.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(239, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Modo de Juego:";
            // 
            // Gmode
            // 
            this.Gmode.BackColor = System.Drawing.Color.DarkOrange;
            this.Gmode.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Gmode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Gmode.FormattingEnabled = true;
            this.Gmode.ItemHeight = 15;
            this.Gmode.Location = new System.Drawing.Point(243, 356);
            this.Gmode.Name = "Gmode";
            this.Gmode.Size = new System.Drawing.Size(145, 19);
            this.Gmode.TabIndex = 13;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Brown;
            this.ExitBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(322, 396);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(111, 42);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "SALIR";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // VerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gmode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mPlayers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Elements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Players);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VerGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerGame";
            this.Load += new System.EventHandler(this.VerGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Players;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Cards;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Elements;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox mPlayers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Gmode;
        private System.Windows.Forms.Button ExitBtn;
    }
}