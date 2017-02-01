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
            this.button_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Calcular
            // 
            this.button_Calcular.BackColor = System.Drawing.SystemColors.Control;
            this.button_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calcular.Location = new System.Drawing.Point(63, 24);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(75, 23);
            this.button_Calcular.TabIndex = 3;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = false;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(219, 59);
            this.Controls.Add(this.button_Calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "main";
            this.Text = "Calculadora Basica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Calcular;
    }
}

