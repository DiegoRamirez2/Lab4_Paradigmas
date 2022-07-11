namespace JuegoDobble
{
    partial class MostrarPuntaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarPuntaje));
            this.label1 = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.Puntajes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puntajes";
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.Brown;
            this.FinishBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FinishBtn.Image = ((System.Drawing.Image)(resources.GetObject("FinishBtn.Image")));
            this.FinishBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinishBtn.Location = new System.Drawing.Point(109, 217);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(110, 42);
            this.FinishBtn.TabIndex = 20;
            this.FinishBtn.Text = "SALIR";
            this.FinishBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // Puntajes
            // 
            this.Puntajes.BackColor = System.Drawing.Color.DarkOrange;
            this.Puntajes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Puntajes.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.Puntajes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Puntajes.FormattingEnabled = true;
            this.Puntajes.HorizontalScrollbar = true;
            this.Puntajes.ItemHeight = 15;
            this.Puntajes.Location = new System.Drawing.Point(39, 41);
            this.Puntajes.Name = "Puntajes";
            this.Puntajes.Size = new System.Drawing.Size(263, 169);
            this.Puntajes.TabIndex = 19;
            this.Puntajes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Puntajes_DrawItem);
            // 
            // MostrarPuntaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(340, 266);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.Puntajes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MostrarPuntaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarPuntaje";
            this.Load += new System.EventHandler(this.MostrarPuntaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.ListBox Puntajes;
    }
}