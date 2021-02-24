
namespace Capitulo_8_9
{
    partial class Cap8
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadena2textBox = new System.Windows.Forms.TextBox();
            this.Ordenbutton = new System.Windows.Forms.Button();
            this.Odenf = new System.Windows.Forms.TextBox();
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.horatextBox = new System.Windows.Forms.TextBox();
            this.Horalabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cadena2textBox);
            this.groupBox1.Controls.Add(this.Ordenbutton);
            this.groupBox1.Controls.Add(this.Odenf);
            this.groupBox1.Controls.Add(this.CadenatextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.horatextBox);
            this.groupBox1.Controls.Add(this.Horalabel);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hacer un programa que le solicite al\r\nusuario dos cadenas y luego las muestre\r\nen" +
    " orden alfabético.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hacer un programa que muestre la hora\r\ndel día en formato AM/FM seguida del\r\naño," +
    " el día y el mes actual.\r\n";
            // 
            // Cadena2textBox
            // 
            this.Cadena2textBox.Location = new System.Drawing.Point(16, 268);
            this.Cadena2textBox.Name = "Cadena2textBox";
            this.Cadena2textBox.Size = new System.Drawing.Size(124, 23);
            this.Cadena2textBox.TabIndex = 6;
            // 
            // Ordenbutton
            // 
            this.Ordenbutton.Location = new System.Drawing.Point(30, 297);
            this.Ordenbutton.Name = "Ordenbutton";
            this.Ordenbutton.Size = new System.Drawing.Size(109, 44);
            this.Ordenbutton.TabIndex = 5;
            this.Ordenbutton.Text = "Orden";
            this.Ordenbutton.UseVisualStyleBackColor = true;
            this.Ordenbutton.Click += new System.EventHandler(this.Ordenbutton_Click);
            // 
            // Odenf
            // 
            this.Odenf.Location = new System.Drawing.Point(172, 235);
            this.Odenf.Multiline = true;
            this.Odenf.Name = "Odenf";
            this.Odenf.Size = new System.Drawing.Size(121, 190);
            this.Odenf.TabIndex = 4;
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(16, 237);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(124, 23);
            this.CadenatextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // horatextBox
            // 
            this.horatextBox.Location = new System.Drawing.Point(94, 82);
            this.horatextBox.Name = "horatextBox";
            this.horatextBox.Size = new System.Drawing.Size(126, 23);
            this.horatextBox.TabIndex = 1;
            // 
            // Horalabel
            // 
            this.Horalabel.AutoSize = true;
            this.Horalabel.Location = new System.Drawing.Point(11, 85);
            this.Horalabel.Name = "Horalabel";
            this.Horalabel.Size = new System.Drawing.Size(77, 15);
            this.Horalabel.TabIndex = 0;
            this.Horalabel.Text = "Hora AM/FM";
            // 
            // Cap8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cap8";
            this.Text = "Cap8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Horalabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox horatextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Cadena2textBox;
        private System.Windows.Forms.Button Ordenbutton;
        private System.Windows.Forms.TextBox Odenf;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}