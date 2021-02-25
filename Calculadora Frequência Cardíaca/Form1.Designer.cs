
namespace Calculadora_Frequência_Cardíaca
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
            this.Calcular = new System.Windows.Forms.Button();
            this.btfem = new System.Windows.Forms.RadioButton();
            this.Sexo = new System.Windows.Forms.GroupBox();
            this.btmasc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbcormax = new System.Windows.Forms.TextBox();
            this.txbcorlmax = new System.Windows.Forms.TextBox();
            this.txbcormin = new System.Windows.Forms.TextBox();
            this.txbcorlmin = new System.Windows.Forms.TextBox();
            this.txbcammax = new System.Windows.Forms.TextBox();
            this.txbcammin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFCmax = new System.Windows.Forms.TextBox();
            this.Sexo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.Location = new System.Drawing.Point(30, 192);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(134, 51);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // btfem
            // 
            this.btfem.AutoSize = true;
            this.btfem.Location = new System.Drawing.Point(14, 60);
            this.btfem.Name = "btfem";
            this.btfem.Size = new System.Drawing.Size(87, 22);
            this.btfem.TabIndex = 3;
            this.btfem.TabStop = true;
            this.btfem.Text = "Feminino";
            this.btfem.UseVisualStyleBackColor = true;
            // 
            // Sexo
            // 
            this.Sexo.BackColor = System.Drawing.Color.Transparent;
            this.Sexo.Controls.Add(this.btmasc);
            this.Sexo.Controls.Add(this.btfem);
            this.Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sexo.Location = new System.Drawing.Point(30, 70);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(134, 100);
            this.Sexo.TabIndex = 4;
            this.Sexo.TabStop = false;
            this.Sexo.Text = "Sexo";
            this.Sexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btmasc
            // 
            this.btmasc.AutoSize = true;
            this.btmasc.Location = new System.Drawing.Point(14, 28);
            this.btmasc.Name = "btmasc";
            this.btmasc.Size = new System.Drawing.Size(94, 22);
            this.btmasc.TabIndex = 5;
            this.btmasc.TabStop = true;
            this.btmasc.Text = "Masculino";
            this.btmasc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Idade";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(82, 30);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(68, 20);
            this.txbIdade.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbcormax);
            this.groupBox2.Controls.Add(this.txbcorlmax);
            this.groupBox2.Controls.Add(this.txbcormin);
            this.groupBox2.Controls.Add(this.txbcorlmin);
            this.groupBox2.Controls.Add(this.txbcammax);
            this.groupBox2.Controls.Add(this.txbcammin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbFCmax);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(208, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 213);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatório";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Corrida Intensa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Corrida Leve:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Caminhada Rápida:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbcormax
            // 
            this.txbcormax.Enabled = false;
            this.txbcormax.Location = new System.Drawing.Point(228, 175);
            this.txbcormax.Name = "txbcormax";
            this.txbcormax.Size = new System.Drawing.Size(63, 24);
            this.txbcormax.TabIndex = 14;
            // 
            // txbcorlmax
            // 
            this.txbcorlmax.Enabled = false;
            this.txbcorlmax.Location = new System.Drawing.Point(229, 145);
            this.txbcorlmax.Name = "txbcorlmax";
            this.txbcorlmax.Size = new System.Drawing.Size(62, 24);
            this.txbcorlmax.TabIndex = 13;
            // 
            // txbcormin
            // 
            this.txbcormin.Enabled = false;
            this.txbcormin.Location = new System.Drawing.Point(158, 175);
            this.txbcormin.Name = "txbcormin";
            this.txbcormin.Size = new System.Drawing.Size(65, 24);
            this.txbcormin.TabIndex = 12;
            // 
            // txbcorlmin
            // 
            this.txbcorlmin.Enabled = false;
            this.txbcorlmin.Location = new System.Drawing.Point(158, 145);
            this.txbcorlmin.Name = "txbcorlmin";
            this.txbcorlmin.Size = new System.Drawing.Size(65, 24);
            this.txbcorlmin.TabIndex = 11;
            // 
            // txbcammax
            // 
            this.txbcammax.Enabled = false;
            this.txbcammax.Location = new System.Drawing.Point(229, 115);
            this.txbcammax.Name = "txbcammax";
            this.txbcammax.Size = new System.Drawing.Size(62, 24);
            this.txbcammax.TabIndex = 10;
            // 
            // txbcammin
            // 
            this.txbcammin.Enabled = false;
            this.txbcammin.Location = new System.Drawing.Point(158, 115);
            this.txbcammin.Name = "txbcammin";
            this.txbcammin.Size = new System.Drawing.Size(65, 24);
            this.txbcammin.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Frequência Alvo (Mínima / Máxima):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "FCmax";
            // 
            // txbFCmax
            // 
            this.txbFCmax.Enabled = false;
            this.txbFCmax.Location = new System.Drawing.Point(158, 38);
            this.txbFCmax.Name = "txbFCmax";
            this.txbFCmax.Size = new System.Drawing.Size(65, 24);
            this.txbFCmax.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(546, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Calcular);
            this.Name = "Form1";
            this.Text = "Calculadora Frequência Cardíaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sexo.ResumeLayout(false);
            this.Sexo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.RadioButton btfem;
        private System.Windows.Forms.GroupBox Sexo;
        private System.Windows.Forms.RadioButton btmasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbcormax;
        private System.Windows.Forms.TextBox txbcorlmax;
        private System.Windows.Forms.TextBox txbcormin;
        private System.Windows.Forms.TextBox txbcorlmin;
        private System.Windows.Forms.TextBox txbcammax;
        private System.Windows.Forms.TextBox txbcammin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFCmax;
    }
}

