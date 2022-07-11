namespace JuegoDobble
{
    partial class CreateGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGame));
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Crear = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.CardPlayer = new System.Windows.Forms.Panel();
            this.numE = new System.Windows.Forms.ComboBox();
            this.NumP = new System.Windows.Forms.TextBox();
            this.CardMode = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Modo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Num = new System.Windows.Forms.Label();
            this.cantidadE = new System.Windows.Forms.Label();
            this.Elem = new System.Windows.Forms.TextBox();
            this.ListElem = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.CardPlayer.SuspendLayout();
            this.CardMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bienvenido al menú de creación de juego";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Brown;
            this.ExitBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(644, 434);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(109, 42);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "SALIR";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese el número de símbolos\r\n que desea por carta:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(78, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ingrese el modo\r\n de juego:\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(80, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 34);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ingrese el número \r\nde jugadores:\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Crear
            // 
            this.Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Crear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Crear.Image = ((System.Drawing.Image)(resources.GetObject("Crear.Image")));
            this.Crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Crear.Location = new System.Drawing.Point(627, 236);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(109, 42);
            this.Crear.TabIndex = 24;
            this.Crear.Text = "CREAR";
            this.Crear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Crear.UseVisualStyleBackColor = false;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 34);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ingrese el número de cartas\r\n que desea en el mazo:\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CardPlayer
            // 
            this.CardPlayer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CardPlayer.Controls.Add(this.numE);
            this.CardPlayer.Controls.Add(this.NumP);
            this.CardPlayer.Controls.Add(this.label1);
            this.CardPlayer.Controls.Add(this.label5);
            this.CardPlayer.Location = new System.Drawing.Point(23, 120);
            this.CardPlayer.Name = "CardPlayer";
            this.CardPlayer.Size = new System.Drawing.Size(348, 110);
            this.CardPlayer.TabIndex = 31;
            // 
            // numE
            // 
            this.numE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numE.FormattingEnabled = true;
            this.numE.Location = new System.Drawing.Point(212, 18);
            this.numE.Name = "numE";
            this.numE.Size = new System.Drawing.Size(121, 21);
            this.numE.TabIndex = 36;
            this.numE.SelectedIndexChanged += new System.EventHandler(this.numE_SelectedIndexChanged);
            // 
            // NumP
            // 
            this.NumP.Location = new System.Drawing.Point(212, 67);
            this.NumP.Name = "NumP";
            this.NumP.Size = new System.Drawing.Size(121, 20);
            this.NumP.TabIndex = 35;
            // 
            // CardMode
            // 
            this.CardMode.BackColor = System.Drawing.Color.DarkCyan;
            this.CardMode.Controls.Add(this.comboBox2);
            this.CardMode.Controls.Add(this.Modo);
            this.CardMode.Controls.Add(this.label3);
            this.CardMode.Controls.Add(this.label4);
            this.CardMode.Location = new System.Drawing.Point(388, 120);
            this.CardMode.Name = "CardMode";
            this.CardMode.Size = new System.Drawing.Size(348, 110);
            this.CardMode.TabIndex = 32;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 32;
            // 
            // Modo
            // 
            this.Modo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Modo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modo.FormattingEnabled = true;
            this.Modo.Location = new System.Drawing.Point(212, 66);
            this.Modo.Name = "Modo";
            this.Modo.Size = new System.Drawing.Size(121, 21);
            this.Modo.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.Num);
            this.panel1.Controls.Add(this.cantidadE);
            this.panel1.Controls.Add(this.Elem);
            this.panel1.Controls.Add(this.ListElem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(23, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 198);
            this.panel1.TabIndex = 36;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.BackColor = System.Drawing.Color.Transparent;
            this.Num.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Num.Location = new System.Drawing.Point(51, 137);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(0, 17);
            this.Num.TabIndex = 41;
            this.Num.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cantidadE
            // 
            this.cantidadE.AutoSize = true;
            this.cantidadE.BackColor = System.Drawing.Color.Transparent;
            this.cantidadE.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.cantidadE.Location = new System.Drawing.Point(3, 120);
            this.cantidadE.Name = "cantidadE";
            this.cantidadE.Size = new System.Drawing.Size(0, 17);
            this.cantidadE.TabIndex = 40;
            this.cantidadE.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Elem
            // 
            this.Elem.Location = new System.Drawing.Point(18, 76);
            this.Elem.MaxLength = 16;
            this.Elem.Name = "Elem";
            this.Elem.Size = new System.Drawing.Size(114, 20);
            this.Elem.TabIndex = 38;
            this.Elem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Elem_KeyDown);
            // 
            // ListElem
            // 
            this.ListElem.BackColor = System.Drawing.Color.Orange;
            this.ListElem.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.ListElem.FormattingEnabled = true;
            this.ListElem.ItemHeight = 15;
            this.ListElem.Location = new System.Drawing.Point(157, 11);
            this.ListElem.Name = "ListElem";
            this.ListElem.Size = new System.Drawing.Size(176, 169);
            this.ListElem.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 51);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingrese los símbolos \r\nque desea en la carta,\r\npresionando enter:\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Primer Paso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Segundo Paso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 29);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tercer Paso:";
            // 
            // CreateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(765, 488);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CardMode);
            this.Controls.Add(this.CardPlayer);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DobbleGame";
            this.Load += new System.EventHandler(this.CreateGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.CardPlayer.ResumeLayout(false);
            this.CardPlayer.PerformLayout();
            this.CardMode.ResumeLayout(false);
            this.CardMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumP;
        private System.Windows.Forms.Panel CardMode;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox Modo;
        private System.Windows.Forms.Panel CardPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Elem;
        private System.Windows.Forms.ListBox ListElem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cantidadE;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.ComboBox numE;
    }
}