namespace HR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRua = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblRua);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // lblRua
            // 
            this.lblRua.Location = new System.Drawing.Point(84, 29);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(100, 20);
            this.lblRua.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(84, 56);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(100, 20);
            this.lblNumero.TabIndex = 1;
            // 
            // lblComplemento
            // 
            this.lblComplemento.Location = new System.Drawing.Point(84, 83);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(100, 20);
            this.lblComplemento.TabIndex = 2;
            // 
            // lblCEP
            // 
            this.lblCEP.Location = new System.Drawing.Point(84, 111);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(100, 20);
            this.lblCEP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Complemento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome";
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(96, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 20);
            this.lblNome.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF";
            // 
            // lblCPF
            // 
            this.lblCPF.Location = new System.Drawing.Point(96, 62);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(100, 20);
            this.lblCPF.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblCEP;
        private System.Windows.Forms.TextBox lblComplemento;
        private System.Windows.Forms.TextBox lblNumero;
        private System.Windows.Forms.TextBox lblRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblCPF;
    }
}

