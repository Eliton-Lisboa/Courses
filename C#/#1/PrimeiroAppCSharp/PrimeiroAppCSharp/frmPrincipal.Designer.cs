namespace PrimeiroAppCSharp
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnMostrarMensagem = new System.Windows.Forms.Button();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnImagens = new System.Windows.Forms.Button();
            this.btnPropriedadesCheckBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(1, 113);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 65);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMensagem.Location = new System.Drawing.Point(85, 205);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Size = new System.Drawing.Size(147, 32);
            this.btnMostrarMensagem.TabIndex = 1;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            this.btnMostrarMensagem.Click += new System.EventHandler(this.btnMostrarMensagem_Click);
            // 
            // btnTabuada
            // 
            this.btnTabuada.Enabled = false;
            this.btnTabuada.Image = global::PrimeiroAppCSharp.Properties.Resources.cbb25ff6f1471030763f0709c87e276a___cone_de_calculadora_by_vexels3;
            this.btnTabuada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTabuada.Location = new System.Drawing.Point(228, 1);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(75, 51);
            this.btnTabuada.TabIndex = 5;
            this.btnTabuada.Text = "Tabuada";
            this.btnTabuada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnImagens
            // 
            this.btnImagens.Enabled = false;
            this.btnImagens.Image = global::PrimeiroAppCSharp.Properties.Resources.depositphotos_116083978_stock_illustration_photographidc_camera_icon;
            this.btnImagens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImagens.Location = new System.Drawing.Point(117, 1);
            this.btnImagens.Name = "btnImagens";
            this.btnImagens.Size = new System.Drawing.Size(75, 51);
            this.btnImagens.TabIndex = 4;
            this.btnImagens.Text = "Imagens";
            this.btnImagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImagens.UseVisualStyleBackColor = true;
            this.btnImagens.Click += new System.EventHandler(this.btnImagens_Click);
            // 
            // btnPropriedadesCheckBox
            // 
            this.btnPropriedadesCheckBox.Enabled = false;
            this.btnPropriedadesCheckBox.Image = global::PrimeiroAppCSharp.Properties.Resources._239523_200_cópia;
            this.btnPropriedadesCheckBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPropriedadesCheckBox.Location = new System.Drawing.Point(12, 1);
            this.btnPropriedadesCheckBox.Name = "btnPropriedadesCheckBox";
            this.btnPropriedadesCheckBox.Size = new System.Drawing.Size(75, 51);
            this.btnPropriedadesCheckBox.TabIndex = 3;
            this.btnPropriedadesCheckBox.Text = "CheckBox";
            this.btnPropriedadesCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPropriedadesCheckBox.UseVisualStyleBackColor = true;
            this.btnPropriedadesCheckBox.Click += new System.EventHandler(this.btnPropriedadesCheckBox_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 261);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnImagens);
            this.Controls.Add(this.btnPropriedadesCheckBox);
            this.Controls.Add(this.btnMostrarMensagem);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Aplicativo em C#";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnMostrarMensagem;
        private System.Windows.Forms.Button btnPropriedadesCheckBox;
        private System.Windows.Forms.Button btnImagens;
        private System.Windows.Forms.Button btnTabuada;
    }
}

