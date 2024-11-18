namespace ListaPooFormExer2
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
            this.calcular = new System.Windows.Forms.Button();
            this.aresta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(310, 221);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 0;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.Area_Aresta);
            // 
            // aresta
            // 
            this.aresta.Location = new System.Drawing.Point(310, 171);
            this.aresta.Name = "aresta";
            this.aresta.Size = new System.Drawing.Size(70, 20);
            this.aresta.TabIndex = 3;
            this.aresta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "aresta";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(345, 262);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(13, 13);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "area: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aresta);
            this.Controls.Add(this.calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.TextBox aresta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label label3;
    }
}

