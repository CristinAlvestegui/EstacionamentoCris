namespace Estacionamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Entrada = new System.Windows.Forms.Button();
            this.Saida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(504, 39);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(62, 105);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Entrada
            // 
            this.Entrada.Location = new System.Drawing.Point(572, 39);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(54, 105);
            this.Entrada.TabIndex = 1;
            this.Entrada.Text = "Entrada";
            this.Entrada.UseVisualStyleBackColor = true;
            this.Entrada.Click += new System.EventHandler(this.Entrada_Click);
            // 
            // Saida
            // 
            this.Saida.Location = new System.Drawing.Point(632, 39);
            this.Saida.Name = "Saida";
            this.Saida.Size = new System.Drawing.Size(54, 105);
            this.Saida.TabIndex = 2;
            this.Saida.Text = "Saida";
            this.Saida.UseVisualStyleBackColor = true;
            this.Saida.Click += new System.EventHandler(this.Saida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Saida);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Entrada;
        private System.Windows.Forms.Button Saida;
    }
}

