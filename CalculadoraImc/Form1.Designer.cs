namespace CalculadoraImc
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.bntCalcula = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de IMC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(64, 16);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(69, 18);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(64, 96);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(75, 18);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura (m):";
            // 
            // bntCalcula
            // 
            this.bntCalcula.BackColor = System.Drawing.Color.IndianRed;
            this.bntCalcula.Location = new System.Drawing.Point(48, 200);
            this.bntCalcula.Name = "bntCalcula";
            this.bntCalcula.Size = new System.Drawing.Size(104, 32);
            this.bntCalcula.TabIndex = 5;
            this.bntCalcula.Text = "CalcularIMC";
            this.bntCalcula.UseVisualStyleBackColor = false;
            this.bntCalcula.Click += new System.EventHandler(this.bntCalcula_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.RosyBrown;
            this.lblResultado.Location = new System.Drawing.Point(8, 32);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 18);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Seu IMC é:";
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(88, 24);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(100, 26);
            this.txtIMC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(160, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calculo do Índice de Massa Corporal (IMC) ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(80, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Informe os dados solicitados para receber o resultado do seu IMC ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudAltura);
            this.panel1.Controls.Add(this.nudPeso);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Controls.Add(this.lblAltura);
            this.panel1.Controls.Add(this.bntCalcula);
            this.panel1.Location = new System.Drawing.Point(184, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 248);
            this.panel1.TabIndex = 10;
            // 
            // nudAltura
            // 
            this.nudAltura.DecimalPlaces = 2;
            this.nudAltura.Location = new System.Drawing.Point(40, 120);
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(120, 26);
            this.nudAltura.TabIndex = 12;
            this.nudAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPeso
            // 
            this.nudPeso.DecimalPlaces = 2;
            this.nudPeso.Location = new System.Drawing.Point(40, 40);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(120, 26);
            this.nudPeso.TabIndex = 11;
            this.nudPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblResultado);
            this.panel2.Controls.Add(this.txtIMC);
            this.panel2.Location = new System.Drawing.Point(184, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 72);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraImc.Properties.Resources.maçabalança;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(568, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button bntCalcula;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Panel panel2;
    }
}

