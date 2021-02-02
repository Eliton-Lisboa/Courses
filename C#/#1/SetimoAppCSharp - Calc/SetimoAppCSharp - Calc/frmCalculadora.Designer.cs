namespace SetimoAppCSharp___Calc
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHistorico.Location = new System.Drawing.Point(12, 12);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.Size = new System.Drawing.Size(246, 20);
            this.txtHistorico.TabIndex = 0;
            this.txtHistorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVisor
            // 
            this.txtVisor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(12, 33);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(246, 38);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.Text = "0";
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.Location = new System.Drawing.Point(12, 99);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(41, 41);
            this.btn7.TabIndex = 1;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn8
            // 
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.Location = new System.Drawing.Point(59, 99);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(41, 41);
            this.btn8.TabIndex = 1;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn9
            // 
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.Location = new System.Drawing.Point(106, 99);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(41, 41);
            this.btn9.TabIndex = 1;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(170, 99);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(41, 41);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btn4
            // 
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(12, 146);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(41, 41);
            this.btn4.TabIndex = 1;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn5
            // 
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(59, 146);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(41, 41);
            this.btn5.TabIndex = 1;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn6
            // 
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(106, 146);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(41, 41);
            this.btn6.TabIndex = 1;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicao.Image")));
            this.btnAdicao.Location = new System.Drawing.Point(170, 146);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(41, 41);
            this.btnAdicao.TabIndex = 1;
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btn1
            // 
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(12, 193);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(41, 41);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn2
            // 
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(59, 193);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(41, 41);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn3
            // 
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(106, 193);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(41, 41);
            this.btn3.TabIndex = 1;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiplicacao.Image")));
            this.btnMultiplicacao.Location = new System.Drawing.Point(170, 193);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(41, 41);
            this.btnMultiplicacao.TabIndex = 1;
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btn0
            // 
            this.btn0.Image = ((System.Drawing.Image)(resources.GetObject("btn0.Image")));
            this.btn0.Location = new System.Drawing.Point(12, 240);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(88, 41);
            this.btn0.TabIndex = 1;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(106, 240);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(41, 41);
            this.btnVirgula.TabIndex = 1;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Image = ((System.Drawing.Image)(resources.GetObject("btnRaiz.Image")));
            this.btnRaiz.Location = new System.Drawing.Point(170, 240);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(41, 41);
            this.btnRaiz.TabIndex = 1;
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackSpace.Image")));
            this.btnBackSpace.Location = new System.Drawing.Point(217, 99);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(41, 41);
            this.btnBackSpace.TabIndex = 1;
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Image = ((System.Drawing.Image)(resources.GetObject("btnSubtracao.Image")));
            this.btnSubtracao.Location = new System.Drawing.Point(217, 146);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(41, 41);
            this.btnSubtracao.TabIndex = 1;
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Image = ((System.Drawing.Image)(resources.GetObject("btnDivisao.Image")));
            this.btnDivisao.Location = new System.Drawing.Point(217, 193);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(41, 41);
            this.btnDivisao.TabIndex = 1;
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Image = ((System.Drawing.Image)(resources.GetObject("btnIgual.Image")));
            this.btnIgual.Location = new System.Drawing.Point(217, 240);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(41, 41);
            this.btnIgual.TabIndex = 1;
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 294);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.txtHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnIgual;
    }
}

