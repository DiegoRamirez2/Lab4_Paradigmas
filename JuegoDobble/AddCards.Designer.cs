namespace JuegoDobble
{
    partial class AddCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCards));
            this.MissingLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumMissing = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NullBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MissingLabel
            // 
            this.MissingLabel.AutoSize = true;
            this.MissingLabel.BackColor = System.Drawing.Color.Transparent;
            this.MissingLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingLabel.Location = new System.Drawing.Point(71, 9);
            this.MissingLabel.Name = "MissingLabel";
            this.MissingLabel.Size = new System.Drawing.Size(92, 29);
            this.MissingLabel.TabIndex = 4;
            this.MissingLabel.Text = "Faltan: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "¿Cuántas cartas desea agregar?";
            // 
            // NumMissing
            // 
            this.NumMissing.FormattingEnabled = true;
            this.NumMissing.Location = new System.Drawing.Point(112, 78);
            this.NumMissing.Name = "NumMissing";
            this.NumMissing.Size = new System.Drawing.Size(121, 21);
            this.NumMissing.TabIndex = 6;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Brown;
            this.ExitBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(112, 162);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(121, 42);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "SALIR     ";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NullBtn
            // 
            this.NullBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NullBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NullBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NullBtn.Image = ((System.Drawing.Image)(resources.GetObject("NullBtn.Image")));
            this.NullBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NullBtn.Location = new System.Drawing.Point(76, 114);
            this.NullBtn.Name = "NullBtn";
            this.NullBtn.Size = new System.Drawing.Size(198, 42);
            this.NullBtn.TabIndex = 14;
            this.NullBtn.Text = "AGREGAR CARTAS";
            this.NullBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NullBtn.UseVisualStyleBackColor = false;
            this.NullBtn.Click += new System.EventHandler(this.NullBtn_Click);
            // 
            // AddCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(353, 214);
            this.Controls.Add(this.NullBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.NumMissing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MissingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCards";
            this.Load += new System.EventHandler(this.AddCards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MissingLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumMissing;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button NullBtn;
    }
}