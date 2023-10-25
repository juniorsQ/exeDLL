namespace inteliMatica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_line4 = new System.Windows.Forms.TextBox();
            this.textBox_compare = new System.Windows.Forms.TextBox();
            this.textBox_line2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_line4
            // 
            this.textBox_line4.Location = new System.Drawing.Point(225, 76);
            this.textBox_line4.Name = "textBox_line4";
            this.textBox_line4.Size = new System.Drawing.Size(304, 27);
            this.textBox_line4.TabIndex = 0;
            // 
            // textBox_compare
            // 
            this.textBox_compare.Location = new System.Drawing.Point(225, 24);
            this.textBox_compare.Name = "textBox_compare";
            this.textBox_compare.Size = new System.Drawing.Size(304, 27);
            this.textBox_compare.TabIndex = 20;
            // 
            // textBox_line2
            // 
            this.textBox_line2.Location = new System.Drawing.Point(225, 126);
            this.textBox_line2.Name = "textBox_line2";
            this.textBox_line2.Size = new System.Drawing.Size(304, 27);
            this.textBox_line2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Descartar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(225, 260);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(304, 95);
            this.textBox_result.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Número de PAN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre del titular :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Código de oficina :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_line2);
            this.Controls.Add(this.textBox_compare);
            this.Controls.Add(this.textBox_line4);
            this.Name = "Form1";
            this.Text = "InteliMatica Demo Interacción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_line4;
        private TextBox textBox_compare;
   
        private TextBox textBox_line2;
        private Button button1;
        private Button button2;
        private TextBox textBox_result;
        private Label label1;
        private Label label2;
        private Label label3;
     
    }
}