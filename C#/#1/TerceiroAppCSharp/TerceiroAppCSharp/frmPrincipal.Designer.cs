namespace TerceiroAppCSharp
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbCelsius1 = new System.Windows.Forms.RadioButton();
            this.rbKelvin1 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit1 = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.rbCelsius2 = new System.Windows.Forms.RadioButton();
            this.rbKelvin2 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit2 = new System.Windows.Forms.RadioButton();
            this.Resultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gbEntrada.SuspendLayout();
            this.gbSaida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(75, 7);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(395, 24);
            this.txtValor.TabIndex = 0;
            // 
            // rbCelsius1
            // 
            this.rbCelsius1.AutoSize = true;
            this.rbCelsius1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius1.Location = new System.Drawing.Point(91, 20);
            this.rbCelsius1.Name = "rbCelsius1";
            this.rbCelsius1.Size = new System.Drawing.Size(72, 23);
            this.rbCelsius1.TabIndex = 2;
            this.rbCelsius1.TabStop = true;
            this.rbCelsius1.Text = "Celsius";
            this.rbCelsius1.UseVisualStyleBackColor = true;
            // 
            // rbKelvin1
            // 
            this.rbKelvin1.AutoSize = true;
            this.rbKelvin1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin1.Location = new System.Drawing.Point(91, 49);
            this.rbKelvin1.Name = "rbKelvin1";
            this.rbKelvin1.Size = new System.Drawing.Size(70, 23);
            this.rbKelvin1.TabIndex = 2;
            this.rbKelvin1.TabStop = true;
            this.rbKelvin1.Text = "Kelvin";
            this.rbKelvin1.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit1
            // 
            this.rbFahrenheit1.AutoSize = true;
            this.rbFahrenheit1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit1.Location = new System.Drawing.Point(91, 78);
            this.rbFahrenheit1.Name = "rbFahrenheit1";
            this.rbFahrenheit1.Size = new System.Drawing.Size(96, 23);
            this.rbFahrenheit1.TabIndex = 2;
            this.rbFahrenheit1.TabStop = true;
            this.rbFahrenheit1.Text = "Fahrenheit";
            this.rbFahrenheit1.UseVisualStyleBackColor = true;
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbKelvin1);
            this.gbEntrada.Controls.Add(this.rbCelsius1);
            this.gbEntrada.Controls.Add(this.rbFahrenheit1);
            this.gbEntrada.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntrada.Location = new System.Drawing.Point(16, 37);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(200, 111);
            this.gbEntrada.TabIndex = 1;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::TerceiroAppCSharp.Properties.Resources.icons8_broom_48px;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(238, 216);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.Location = new System.Drawing.Point(130, 216);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(102, 30);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.rbKelvin2);
            this.gbSaida.Controls.Add(this.rbFahrenheit2);
            this.gbSaida.Controls.Add(this.rbCelsius2);
            this.gbSaida.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaida.Location = new System.Drawing.Point(260, 37);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(200, 111);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            // 
            // rbCelsius2
            // 
            this.rbCelsius2.AutoSize = true;
            this.rbCelsius2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius2.Location = new System.Drawing.Point(87, 20);
            this.rbCelsius2.Name = "rbCelsius2";
            this.rbCelsius2.Size = new System.Drawing.Size(72, 23);
            this.rbCelsius2.TabIndex = 2;
            this.rbCelsius2.TabStop = true;
            this.rbCelsius2.Text = "Celsius";
            this.rbCelsius2.UseVisualStyleBackColor = true;
            // 
            // rbKelvin2
            // 
            this.rbKelvin2.AutoSize = true;
            this.rbKelvin2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin2.Location = new System.Drawing.Point(87, 49);
            this.rbKelvin2.Name = "rbKelvin2";
            this.rbKelvin2.Size = new System.Drawing.Size(70, 23);
            this.rbKelvin2.TabIndex = 2;
            this.rbKelvin2.TabStop = true;
            this.rbKelvin2.Text = "Kelvin";
            this.rbKelvin2.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit2
            // 
            this.rbFahrenheit2.AutoSize = true;
            this.rbFahrenheit2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit2.Location = new System.Drawing.Point(87, 78);
            this.rbFahrenheit2.Name = "rbFahrenheit2";
            this.rbFahrenheit2.Size = new System.Drawing.Size(96, 23);
            this.rbFahrenheit2.TabIndex = 2;
            this.rbFahrenheit2.TabStop = true;
            this.rbFahrenheit2.Text = "Fahrenheit";
            this.rbFahrenheit2.UseVisualStyleBackColor = true;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(12, 156);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(57, 23);
            this.Resultado.TabIndex = 0;
            this.Resultado.Text = "Valor:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(75, 154);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(395, 24);
            this.txtResultado.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 253);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.gbEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbCelsius1;
        private System.Windows.Forms.RadioButton rbKelvin1;
        private System.Windows.Forms.RadioButton rbFahrenheit1;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.RadioButton rbCelsius2;
        private System.Windows.Forms.RadioButton rbKelvin2;
        private System.Windows.Forms.RadioButton rbFahrenheit2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

