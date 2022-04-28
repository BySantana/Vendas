namespace Aula30
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lstProduto = new System.Windows.Forms.ListBox();
            this.lstPreco = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(66, 23);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(253, 23);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(98, 59);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(75, 23);
            this.btnLancar.TabIndex = 2;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lstProduto
            // 
            this.lstProduto.FormattingEnabled = true;
            this.lstProduto.Location = new System.Drawing.Point(19, 101);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(154, 186);
            this.lstProduto.TabIndex = 3;
            // 
            // lstPreco
            // 
            this.lstPreco.FormattingEnabled = true;
            this.lstPreco.Location = new System.Drawing.Point(179, 101);
            this.lstPreco.Name = "lstPreco";
            this.lstPreco.Size = new System.Drawing.Size(148, 186);
            this.lstPreco.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0.00";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(179, 59);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 356);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPreco);
            this.Controls.Add(this.lstProduto);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.ListBox lstProduto;
        private System.Windows.Forms.ListBox lstPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemover;
    }
}

