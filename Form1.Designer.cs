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
            txt_texto1 = new TextBox();
            txt_pan = new TextBox();
            txt_texto2 = new TextBox();
            button1 = new Button();
            btn_getPan = new Button();
            textBox_result = new TextBox();
            lbl_txt_pan = new Label();
            lbl_txt1 = new Label();
            lbl_txt2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            txt_texto3 = new TextBox();
            lbl_txt3 = new Label();
            txt_texto4 = new TextBox();
            lbl_txt4 = new Label();
            btn_statusprinter = new Button();
            btn_eject = new Button();
            btn_limpiarCampos = new Button();
            SuspendLayout();
            // 
            // txt_texto1
            // 
            txt_texto1.Location = new Point(225, 76);
            txt_texto1.Name = "txt_texto1";
            txt_texto1.Size = new Size(303, 27);
            txt_texto1.TabIndex = 0;
            // 
            // txt_pan
            // 
            txt_pan.Location = new Point(225, 24);
            txt_pan.Name = "txt_pan";
            txt_pan.Size = new Size(303, 27);
            txt_pan.TabIndex = 20;
            // 
            // txt_texto2
            // 
            txt_texto2.Location = new Point(225, 125);
            txt_texto2.Name = "txt_texto2";
            txt_texto2.Size = new Size(303, 27);
            txt_texto2.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(995, 29);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 24;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_getPan
            // 
            btn_getPan.Location = new Point(995, 136);
            btn_getPan.Name = "btn_getPan";
            btn_getPan.Size = new Size(125, 29);
            btn_getPan.TabIndex = 25;
            btn_getPan.Text = "Leer PAN";
            btn_getPan.UseVisualStyleBackColor = true;
            btn_getPan.Click += btn_getPan_Click;
            // 
            // textBox_result
            // 
            textBox_result.Location = new Point(225, 448);
            textBox_result.Multiline = true;
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(303, 95);
            textBox_result.TabIndex = 26;
            // 
            // lbl_txt_pan
            // 
            lbl_txt_pan.AutoSize = true;
            lbl_txt_pan.Location = new Point(46, 35);
            lbl_txt_pan.Name = "lbl_txt_pan";
            lbl_txt_pan.Size = new Size(91, 20);
            lbl_txt_pan.TabIndex = 27;
            lbl_txt_pan.Text = "TEXTO PAN :";
            // 
            // lbl_txt1
            // 
            lbl_txt1.AutoSize = true;
            lbl_txt1.Location = new Point(46, 87);
            lbl_txt1.Name = "lbl_txt1";
            lbl_txt1.Size = new Size(64, 20);
            lbl_txt1.TabIndex = 28;
            lbl_txt1.Text = "TEXTO 1";
            // 
            // lbl_txt2
            // 
            lbl_txt2.AutoSize = true;
            lbl_txt2.Location = new Point(46, 136);
            lbl_txt2.Name = "lbl_txt2";
            lbl_txt2.Size = new Size(64, 20);
            lbl_txt2.TabIndex = 29;
            lbl_txt2.Text = "TEXTO 2";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_texto3
            // 
            txt_texto3.Location = new Point(225, 179);
            txt_texto3.Name = "txt_texto3";
            txt_texto3.Size = new Size(303, 27);
            txt_texto3.TabIndex = 30;
            // 
            // lbl_txt3
            // 
            lbl_txt3.AutoSize = true;
            lbl_txt3.Location = new Point(46, 189);
            lbl_txt3.Name = "lbl_txt3";
            lbl_txt3.Size = new Size(64, 20);
            lbl_txt3.TabIndex = 31;
            lbl_txt3.Text = "TEXTO 3";
            // 
            // txt_texto4
            // 
            txt_texto4.Location = new Point(225, 231);
            txt_texto4.Name = "txt_texto4";
            txt_texto4.Size = new Size(303, 27);
            txt_texto4.TabIndex = 33;
            // 
            // lbl_txt4
            // 
            lbl_txt4.AutoSize = true;
            lbl_txt4.Location = new Point(46, 241);
            lbl_txt4.Name = "lbl_txt4";
            lbl_txt4.Size = new Size(64, 20);
            lbl_txt4.TabIndex = 34;
            lbl_txt4.Text = "TEXTO 4";
            // 
            // btn_statusprinter
            // 
            btn_statusprinter.Location = new Point(995, 83);
            btn_statusprinter.Name = "btn_statusprinter";
            btn_statusprinter.Size = new Size(125, 29);
            btn_statusprinter.TabIndex = 35;
            btn_statusprinter.Text = "Estatus ";
            btn_statusprinter.UseVisualStyleBackColor = true;
            btn_statusprinter.Click += btn_statusprinter_Click;
            // 
            // btn_eject
            // 
            btn_eject.Location = new Point(995, 189);
            btn_eject.Name = "btn_eject";
            btn_eject.Size = new Size(125, 29);
            btn_eject.TabIndex = 36;
            btn_eject.Text = "Expulsar tarjeta";
            btn_eject.UseVisualStyleBackColor = true;
            btn_eject.Click += btn_eject_Click;
            // 
            // btn_limpiarCampos
            // 
            btn_limpiarCampos.Location = new Point(995, 241);
            btn_limpiarCampos.Name = "btn_limpiarCampos";
            btn_limpiarCampos.Size = new Size(125, 29);
            btn_limpiarCampos.TabIndex = 37;
            btn_limpiarCampos.Text = "Limpiar Campos";
            btn_limpiarCampos.UseVisualStyleBackColor = true;
            btn_limpiarCampos.Click += btn_limpiarCampos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 592);
            Controls.Add(btn_limpiarCampos);
            Controls.Add(btn_eject);
            Controls.Add(btn_statusprinter);
            Controls.Add(lbl_txt4);
            Controls.Add(txt_texto4);
            Controls.Add(lbl_txt3);
            Controls.Add(txt_texto3);
            Controls.Add(lbl_txt2);
            Controls.Add(lbl_txt1);
            Controls.Add(lbl_txt_pan);
            Controls.Add(textBox_result);
            Controls.Add(btn_getPan);
            Controls.Add(button1);
            Controls.Add(txt_texto2);
            Controls.Add(txt_pan);
            Controls.Add(txt_texto1);
            Name = "Form1";
            Text = "InteliPOINTMAN Demo Interacción 100X100 BANCO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_texto1;
        private TextBox txt_pan;

        private TextBox txt_texto2;
        private Button button1;
        private Button btn_getPan;
        private TextBox textBox_result;
        private Label lbl_txt_pan;
        private Label lbl_txt1;
        private Label lbl_txt2;
        private OpenFileDialog openFileDialog1;
        private TextBox txt_texto3;
        private Label lbl_txt3;
        private TextBox textBox1;
        private Label lbl_txt4;
        private TextBox txt_texto4;
        private Button btn_statusprinter;
        private Button btn_eject;
        private Button btn_limpiarCampos;
    }
}