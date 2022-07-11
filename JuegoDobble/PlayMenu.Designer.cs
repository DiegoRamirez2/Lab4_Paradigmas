namespace JuegoDobble
{
    partial class PlayMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.SpotItBtn = new System.Windows.Forms.Button();
            this.PassBtn = new System.Windows.Forms.Button();
            this.NullBtn = new System.Windows.Forms.Button();
            this.PointsBtn = new System.Windows.Forms.Button();
            this.AddCardsBtn = new System.Windows.Forms.Button();
            this.C_one = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CardOne = new System.Windows.Forms.ListBox();
            this.CardTwo = new System.Windows.Forms.ListBox();
            this.CompararLabel = new System.Windows.Forms.Label();
            this.ElemElected = new System.Windows.Forms.TextBox();
            this.IsTurn = new System.Windows.Forms.Label();
            this.C_two = new System.Windows.Forms.Label();
            this.AcceptElem = new System.Windows.Forms.Button();
            this.CorrectCards = new System.Windows.Forms.ErrorProvider(this.components);
            this.PlayCards = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectCards)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido al Menu de Juego";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox2.Location = new System.Drawing.Point(339, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 641);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.Brown;
            this.FinishBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FinishBtn.Image = ((System.Drawing.Image)(resources.GetObject("FinishBtn.Image")));
            this.FinishBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinishBtn.Location = new System.Drawing.Point(39, 444);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(261, 42);
            this.FinishBtn.TabIndex = 8;
            this.FinishBtn.Text = "FINALIZAR JUEGO";
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SpotItBtn
            // 
            this.SpotItBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SpotItBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpotItBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpotItBtn.Image = ((System.Drawing.Image)(resources.GetObject("SpotItBtn.Image")));
            this.SpotItBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SpotItBtn.Location = new System.Drawing.Point(39, 300);
            this.SpotItBtn.Name = "SpotItBtn";
            this.SpotItBtn.Size = new System.Drawing.Size(261, 42);
            this.SpotItBtn.TabIndex = 11;
            this.SpotItBtn.Text = "¡SPOT IT!";
            this.SpotItBtn.UseVisualStyleBackColor = false;
            this.SpotItBtn.Click += new System.EventHandler(this.SpotItBtn_Click);
            // 
            // PassBtn
            // 
            this.PassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PassBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassBtn.Image = ((System.Drawing.Image)(resources.GetObject("PassBtn.Image")));
            this.PassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassBtn.Location = new System.Drawing.Point(39, 252);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(261, 42);
            this.PassBtn.TabIndex = 12;
            this.PassBtn.Text = "PASAR TURNO";
            this.PassBtn.UseVisualStyleBackColor = false;
            this.PassBtn.Click += new System.EventHandler(this.PassBtn_Click);
            // 
            // NullBtn
            // 
            this.NullBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NullBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NullBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NullBtn.Image = ((System.Drawing.Image)(resources.GetObject("NullBtn.Image")));
            this.NullBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NullBtn.Location = new System.Drawing.Point(39, 204);
            this.NullBtn.Name = "NullBtn";
            this.NullBtn.Size = new System.Drawing.Size(261, 42);
            this.NullBtn.TabIndex = 13;
            this.NullBtn.Text = "VOLTEAR CARTAS";
            this.NullBtn.UseVisualStyleBackColor = false;
            this.NullBtn.Click += new System.EventHandler(this.NullBtn_Click);
            // 
            // PointsBtn
            // 
            this.PointsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PointsBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PointsBtn.Image = ((System.Drawing.Image)(resources.GetObject("PointsBtn.Image")));
            this.PointsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PointsBtn.Location = new System.Drawing.Point(39, 396);
            this.PointsBtn.Name = "PointsBtn";
            this.PointsBtn.Size = new System.Drawing.Size(261, 42);
            this.PointsBtn.TabIndex = 10;
            this.PointsBtn.Text = "  TABLA DE PUNTAJES";
            this.PointsBtn.UseVisualStyleBackColor = false;
            // 
            // AddCardsBtn
            // 
            this.AddCardsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddCardsBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCardsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCardsBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddCardsBtn.Image")));
            this.AddCardsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCardsBtn.Location = new System.Drawing.Point(39, 348);
            this.AddCardsBtn.Name = "AddCardsBtn";
            this.AddCardsBtn.Size = new System.Drawing.Size(261, 42);
            this.AddCardsBtn.TabIndex = 14;
            this.AddCardsBtn.Text = "AGREGAR CARTAS";
            this.AddCardsBtn.UseVisualStyleBackColor = false;
            // 
            // C_one
            // 
            this.C_one.AutoSize = true;
            this.C_one.BackColor = System.Drawing.Color.Transparent;
            this.C_one.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.C_one.Location = new System.Drawing.Point(360, 51);
            this.C_one.Name = "C_one";
            this.C_one.Size = new System.Drawing.Size(227, 23);
            this.C_one.TabIndex = 15;
            this.C_one.Text = "ELEMENTOS CARTA N°1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "¿Qué desea hacer?";
            // 
            // CardOne
            // 
            this.CardOne.BackColor = System.Drawing.Color.DarkOrange;
            this.CardOne.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.CardOne.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CardOne.FormattingEnabled = true;
            this.CardOne.HorizontalScrollbar = true;
            this.CardOne.ItemHeight = 15;
            this.CardOne.Location = new System.Drawing.Point(364, 77);
            this.CardOne.Name = "CardOne";
            this.CardOne.Size = new System.Drawing.Size(223, 169);
            this.CardOne.TabIndex = 18;
            // 
            // CardTwo
            // 
            this.CardTwo.BackColor = System.Drawing.Color.DarkOrange;
            this.CardTwo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.CardTwo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CardTwo.FormattingEnabled = true;
            this.CardTwo.HorizontalScrollbar = true;
            this.CardTwo.ItemHeight = 15;
            this.CardTwo.Location = new System.Drawing.Point(611, 77);
            this.CardTwo.Name = "CardTwo";
            this.CardTwo.Size = new System.Drawing.Size(223, 169);
            this.CardTwo.TabIndex = 19;
            // 
            // CompararLabel
            // 
            this.CompararLabel.AutoSize = true;
            this.CompararLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompararLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.CompararLabel.Location = new System.Drawing.Point(454, 271);
            this.CompararLabel.Name = "CompararLabel";
            this.CompararLabel.Size = new System.Drawing.Size(279, 23);
            this.CompararLabel.TabIndex = 20;
            this.CompararLabel.Text = "¡Ingrese el elemento en común!";
            // 
            // ElemElected
            // 
            this.ElemElected.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.ElemElected.Location = new System.Drawing.Point(498, 297);
            this.ElemElected.Name = "ElemElected";
            this.ElemElected.Size = new System.Drawing.Size(192, 21);
            this.ElemElected.TabIndex = 21;
            // 
            // IsTurn
            // 
            this.IsTurn.AutoSize = true;
            this.IsTurn.BackColor = System.Drawing.Color.Transparent;
            this.IsTurn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.IsTurn.Location = new System.Drawing.Point(99, 124);
            this.IsTurn.Name = "IsTurn";
            this.IsTurn.Size = new System.Drawing.Size(133, 23);
            this.IsTurn.TabIndex = 22;
            this.IsTurn.Text = "Es el turno de:";
            this.IsTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // C_two
            // 
            this.C_two.AutoSize = true;
            this.C_two.BackColor = System.Drawing.Color.Transparent;
            this.C_two.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.C_two.Location = new System.Drawing.Point(607, 51);
            this.C_two.Name = "C_two";
            this.C_two.Size = new System.Drawing.Size(227, 23);
            this.C_two.TabIndex = 23;
            this.C_two.Text = "ELEMENTOS CARTA N°1:";
            // 
            // AcceptElem
            // 
            this.AcceptElem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AcceptElem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptElem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptElem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcceptElem.Location = new System.Drawing.Point(548, 324);
            this.AcceptElem.Name = "AcceptElem";
            this.AcceptElem.Size = new System.Drawing.Size(89, 42);
            this.AcceptElem.TabIndex = 24;
            this.AcceptElem.Text = "ACEPTAR";
            this.AcceptElem.UseVisualStyleBackColor = false;
            this.AcceptElem.Click += new System.EventHandler(this.AcceptElem_Click);
            // 
            // CorrectCards
            // 
            this.CorrectCards.ContainerControl = this;
            // 
            // PlayCards
            // 
            this.PlayCards.AutoSize = true;
            this.PlayCards.BackColor = System.Drawing.Color.Transparent;
            this.PlayCards.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.PlayCards.Location = new System.Drawing.Point(418, 12);
            this.PlayCards.Name = "PlayCards";
            this.PlayCards.Size = new System.Drawing.Size(377, 27);
            this.PlayCards.TabIndex = 25;
            this.PlayCards.Text = "ESTAS SON LAS CARTAS EN JUEGO:";
            // 
            // PlayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(859, 507);
            this.Controls.Add(this.PlayCards);
            this.Controls.Add(this.AcceptElem);
            this.Controls.Add(this.C_two);
            this.Controls.Add(this.IsTurn);
            this.Controls.Add(this.ElemElected);
            this.Controls.Add(this.CompararLabel);
            this.Controls.Add(this.CardTwo);
            this.Controls.Add(this.CardOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.C_one);
            this.Controls.Add(this.AddCardsBtn);
            this.Controls.Add(this.NullBtn);
            this.Controls.Add(this.PassBtn);
            this.Controls.Add(this.SpotItBtn);
            this.Controls.Add(this.PointsBtn);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayMenu";
            this.Text = "PlayMenu";
            this.Load += new System.EventHandler(this.PlayMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorrectCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button SpotItBtn;
        private System.Windows.Forms.Button PassBtn;
        private System.Windows.Forms.Button NullBtn;
        private System.Windows.Forms.Button PointsBtn;
        private System.Windows.Forms.Button AddCardsBtn;
        private System.Windows.Forms.Label C_one;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox CardOne;
        private System.Windows.Forms.ListBox CardTwo;
        private System.Windows.Forms.Label CompararLabel;
        private System.Windows.Forms.TextBox ElemElected;
        private System.Windows.Forms.Label IsTurn;
        private System.Windows.Forms.Label C_two;
        private System.Windows.Forms.Button AcceptElem;
        private System.Windows.Forms.ErrorProvider CorrectCards;
        private System.Windows.Forms.Label PlayCards;
    }
}