namespace IMC
{
    partial class frmIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso Ideal";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.ForeColor = System.Drawing.Color.Red;
            this.lblPesoIdeal.Location = new System.Drawing.Point(191, 299);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(167, 63);
            this.lblPesoIdeal.TabIndex = 3;
            this.lblPesoIdeal.Text = "00.00";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(214, 92);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(113, 20);
            this.txtAltura.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnFeminino);
            this.groupBox1.Controls.Add(this.rbnMasculino);
            this.groupBox1.Location = new System.Drawing.Point(152, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMasculino.Location = new System.Drawing.Point(19, 19);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(89, 21);
            this.rbnMasculino.TabIndex = 0;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            this.rbnMasculino.CheckedChanged += new System.EventHandler(this.rbnMasculino_CheckedChanged);
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFeminino.Location = new System.Drawing.Point(143, 19);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(83, 21);
            this.rbnFeminino.TabIndex = 1;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            this.rbnFeminino.CheckedChanged += new System.EventHandler(this.rbnFeminino_CheckedChanged);
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo IMC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.RadioButton rbnMasculino;
    }
}

