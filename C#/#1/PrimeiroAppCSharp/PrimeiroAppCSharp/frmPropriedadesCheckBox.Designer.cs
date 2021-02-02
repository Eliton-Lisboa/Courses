namespace PrimeiroAppCSharp
{
    partial class frmPropriedadesCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropriedadesCheckBox));
            this.chkPessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkPessoaJuridica = new System.Windows.Forms.CheckBox();
            this.pnlPessoaFisica = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPessoaJuridica = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPessoaFisica.SuspendLayout();
            this.pnlPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPessoaFisica
            // 
            this.chkPessoaFisica.AutoSize = true;
            this.chkPessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPessoaFisica.Location = new System.Drawing.Point(42, 133);
            this.chkPessoaFisica.Name = "chkPessoaFisica";
            this.chkPessoaFisica.Size = new System.Drawing.Size(120, 21);
            this.chkPessoaFisica.TabIndex = 0;
            this.chkPessoaFisica.Text = "Pessoa Física";
            this.chkPessoaFisica.UseVisualStyleBackColor = true;
            this.chkPessoaFisica.CheckStateChanged += new System.EventHandler(this.chkPessoaFisica_CheckStateChanged);
            // 
            // chkPessoaJuridica
            // 
            this.chkPessoaJuridica.AutoSize = true;
            this.chkPessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPessoaJuridica.Location = new System.Drawing.Point(42, 179);
            this.chkPessoaJuridica.Name = "chkPessoaJuridica";
            this.chkPessoaJuridica.Size = new System.Drawing.Size(131, 21);
            this.chkPessoaJuridica.TabIndex = 1;
            this.chkPessoaJuridica.Text = "Pessoa Jurídica";
            this.chkPessoaJuridica.UseVisualStyleBackColor = true;
            this.chkPessoaJuridica.CheckStateChanged += new System.EventHandler(this.chkPessoaJuridica_CheckStateChanged);
            // 
            // pnlPessoaFisica
            // 
            this.pnlPessoaFisica.Controls.Add(this.textBox2);
            this.pnlPessoaFisica.Controls.Add(this.label2);
            this.pnlPessoaFisica.Controls.Add(this.textBox1);
            this.pnlPessoaFisica.Controls.Add(this.label1);
            this.pnlPessoaFisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPessoaFisica.Location = new System.Drawing.Point(226, 39);
            this.pnlPessoaFisica.Name = "pnlPessoaFisica";
            this.pnlPessoaFisica.Size = new System.Drawing.Size(284, 126);
            this.pnlPessoaFisica.TabIndex = 2;
            this.pnlPessoaFisica.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(80, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlPessoaJuridica
            // 
            this.pnlPessoaJuridica.Controls.Add(this.textBox3);
            this.pnlPessoaJuridica.Controls.Add(this.label3);
            this.pnlPessoaJuridica.Controls.Add(this.textBox4);
            this.pnlPessoaJuridica.Controls.Add(this.label4);
            this.pnlPessoaJuridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPessoaJuridica.Location = new System.Drawing.Point(226, 179);
            this.pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            this.pnlPessoaJuridica.Size = new System.Drawing.Size(284, 126);
            this.pnlPessoaJuridica.TabIndex = 4;
            this.pnlPessoaJuridica.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(80, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 25);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(80, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 25);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmPropriedadesCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 366);
            this.Controls.Add(this.pnlPessoaJuridica);
            this.Controls.Add(this.pnlPessoaFisica);
            this.Controls.Add(this.chkPessoaJuridica);
            this.Controls.Add(this.chkPessoaFisica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPropriedadesCheckBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Propriedades do CheckBox";
            this.Load += new System.EventHandler(this.frmPropriedadesCheckBox_Load);
            this.pnlPessoaFisica.ResumeLayout(false);
            this.pnlPessoaFisica.PerformLayout();
            this.pnlPessoaJuridica.ResumeLayout(false);
            this.pnlPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPessoaFisica;
        private System.Windows.Forms.CheckBox chkPessoaJuridica;
        private System.Windows.Forms.Panel pnlPessoaFisica;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPessoaJuridica;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}