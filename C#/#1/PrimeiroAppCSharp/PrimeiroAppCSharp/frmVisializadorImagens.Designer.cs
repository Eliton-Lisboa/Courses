namespace PrimeiroAppCSharp
{
    partial class frmVisializadorImagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisializadorImagens));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbImagens = new System.Windows.Forms.PictureBox();
            this.rbStretch = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.btnMostrarImagem = new System.Windows.Forms.Button();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.ofdImagens = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrimeiroAppCSharp.Properties.Resources.album_de_assinatura_foto_dourado_album_de_assinatura;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbImagens
            // 
            this.pbImagens.Location = new System.Drawing.Point(103, 59);
            this.pbImagens.Name = "pbImagens";
            this.pbImagens.Size = new System.Drawing.Size(342, 231);
            this.pbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagens.TabIndex = 1;
            this.pbImagens.TabStop = false;
            this.pbImagens.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rbStretch
            // 
            this.rbStretch.AutoSize = true;
            this.rbStretch.Location = new System.Drawing.Point(309, 378);
            this.rbStretch.Name = "rbStretch";
            this.rbStretch.Size = new System.Drawing.Size(59, 17);
            this.rbStretch.TabIndex = 2;
            this.rbStretch.TabStop = true;
            this.rbStretch.Text = "Stretch";
            this.rbStretch.UseVisualStyleBackColor = true;
            this.rbStretch.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(414, 378);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 3;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // btnMostrarImagem
            // 
            this.btnMostrarImagem.Location = new System.Drawing.Point(12, 378);
            this.btnMostrarImagem.Name = "btnMostrarImagem";
            this.btnMostrarImagem.Size = new System.Drawing.Size(108, 28);
            this.btnMostrarImagem.TabIndex = 4;
            this.btnMostrarImagem.Text = " Mostrar Imagem";
            this.btnMostrarImagem.UseVisualStyleBackColor = true;
            this.btnMostrarImagem.Click += new System.EventHandler(this.btnMostrarImagem_Click);
            // 
            // btnLimparImagem
            // 
            this.btnLimparImagem.Location = new System.Drawing.Point(126, 378);
            this.btnLimparImagem.Name = "btnLimparImagem";
            this.btnLimparImagem.Size = new System.Drawing.Size(108, 28);
            this.btnLimparImagem.TabIndex = 5;
            this.btnLimparImagem.Text = "Limpar Imagem";
            this.btnLimparImagem.UseVisualStyleBackColor = true;
            this.btnLimparImagem.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // ofdImagens
            // 
            this.ofdImagens.FileName = "openFileDialog1";
            // 
            // frmVisializadorImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 418);
            this.Controls.Add(this.btnLimparImagem);
            this.Controls.Add(this.btnMostrarImagem);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.rbStretch);
            this.Controls.Add(this.pbImagens);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmVisializadorImagens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de imagens";
            this.Load += new System.EventHandler(this.frmVisializadorImagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbImagens;
        private System.Windows.Forms.RadioButton rbStretch;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.Button btnMostrarImagem;
        private System.Windows.Forms.Button btnLimparImagem;
        private System.Windows.Forms.OpenFileDialog ofdImagens;
    }
}