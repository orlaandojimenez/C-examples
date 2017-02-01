namespace OOP2
{
    partial class Form1
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
            System.Windows.Forms.Button buttonClick;
            this.labelClick = new System.Windows.Forms.Label();
            this.labelMouse = new System.Windows.Forms.Label();
            this.textBoxKeyPress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelKeyPress = new System.Windows.Forms.Label();
            this.textBoxKeyPress2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            buttonClick = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClick
            // 
            buttonClick.Location = new System.Drawing.Point(16, 102);
            buttonClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new System.Drawing.Size(88, 29);
            buttonClick.TabIndex = 0;
            buttonClick.Text = "Action Button";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            buttonClick.MouseLeave += new System.EventHandler(this.buttonClick_MouseLeave);
            buttonClick.MouseHover += new System.EventHandler(this.buttonClick_MouseHover);
            // 
            // labelClick
            // 
            this.labelClick.AutoSize = true;
            this.labelClick.Location = new System.Drawing.Point(14, 64);
            this.labelClick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClick.Name = "labelClick";
            this.labelClick.Size = new System.Drawing.Size(59, 13);
            this.labelClick.TabIndex = 1;
            this.labelClick.Text = "Label Click";
            this.labelClick.Click += new System.EventHandler(this.labelClick_Click);
            // 
            // labelMouse
            // 
            this.labelMouse.AutoSize = true;
            this.labelMouse.Location = new System.Drawing.Point(14, 33);
            this.labelMouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMouse.Name = "labelMouse";
            this.labelMouse.Size = new System.Drawing.Size(68, 13);
            this.labelMouse.TabIndex = 2;
            this.labelMouse.Text = "Label Mouse";
            this.labelMouse.Click += new System.EventHandler(this.labelMouse_Click);
            // 
            // textBoxKeyPress
            // 
            this.textBoxKeyPress.Location = new System.Drawing.Point(2, 33);
            this.textBoxKeyPress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKeyPress.Name = "textBoxKeyPress";
            this.textBoxKeyPress.Size = new System.Drawing.Size(76, 20);
            this.textBoxKeyPress.TabIndex = 3;
            this.textBoxKeyPress.TextChanged += new System.EventHandler(this.textBoxKeyPress_TextChanged);
            this.textBoxKeyPress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMouse);
            this.panel1.Controls.Add(buttonClick);
            this.panel1.Controls.Add(this.labelClick);
            this.panel1.Location = new System.Drawing.Point(9, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 149);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelKeyPress);
            this.panel2.Controls.Add(this.textBoxKeyPress2);
            this.panel2.Controls.Add(this.textBoxKeyPress);
            this.panel2.Location = new System.Drawing.Point(147, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 149);
            this.panel2.TabIndex = 5;
            // 
            // labelKeyPress
            // 
            this.labelKeyPress.AutoSize = true;
            this.labelKeyPress.Location = new System.Drawing.Point(2, 110);
            this.labelKeyPress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKeyPress.Name = "labelKeyPress";
            this.labelKeyPress.Size = new System.Drawing.Size(0, 13);
            this.labelKeyPress.TabIndex = 3;
            // 
            // textBoxKeyPress2
            // 
            this.textBoxKeyPress2.Location = new System.Drawing.Point(2, 64);
            this.textBoxKeyPress2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKeyPress2.Name = "textBoxKeyPress2";
            this.textBoxKeyPress2.Size = new System.Drawing.Size(76, 20);
            this.textBoxKeyPress2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eventos Click y Mouse Hover";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Evento KeyPress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClick;
        private System.Windows.Forms.Label labelMouse;
        private System.Windows.Forms.TextBox textBoxKeyPress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxKeyPress2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKeyPress;
        private System.Windows.Forms.Label label2;

    }
}

