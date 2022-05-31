namespace Estacionamento
{
    partial class SiteEsta
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Flag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Miltown II", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(-46, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(834, 68);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "*** Estacionamento ***";
            // 
            // Flag
            // 
            this.Flag.BackColor = System.Drawing.Color.Transparent;
            this.Flag.BackgroundImage = global::Estacionamento.Properties.Resources.BandeiraLinda;
            this.Flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Flag.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.Flag.FlatAppearance.BorderSize = 0;
            this.Flag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Flag.ForeColor = System.Drawing.Color.Transparent;
            this.Flag.Location = new System.Drawing.Point(81, 24);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(576, 508);
            this.Flag.TabIndex = 1;
            this.Flag.UseVisualStyleBackColor = false;
            this.Flag.Click += new System.EventHandler(this.Flag_Click);
            // 
            // SiteEsta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(768, 729);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Flag);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.HotPink;
            this.Name = "SiteEsta";
            this.Text = "SiteEsta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Flag;
    }
}