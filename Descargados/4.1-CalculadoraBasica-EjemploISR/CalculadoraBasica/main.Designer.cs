namespace CalculadoraBasica
{
    partial class main
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
            this.textBox_Val1 = new System.Windows.Forms.TextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Val1
            // 
            this.textBox_Val1.Location = new System.Drawing.Point(86, 12);
            this.textBox_Val1.Name = "textBox_Val1";
            this.textBox_Val1.Size = new System.Drawing.Size(199, 20);
            this.textBox_Val1.TabIndex = 0;
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Location = new System.Drawing.Point(12, 70);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(99, 13);
            this.label_Resultado.TabIndex = 2;
            this.label_Resultado.Text = "Label de Resultado";
            // 
            // button_Calcular
            // 
            this.button_Calcular.BackColor = System.Drawing.SystemColors.Control;
            this.button_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calcular.Location = new System.Drawing.Point(12, 86);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(75, 23);
            this.button_Calcular.TabIndex = 3;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = false;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sueldo Bruto";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.textBox_Val1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "main";
            this.Text = "Calculadora Basica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Val1;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.Label label1;
    }
}

