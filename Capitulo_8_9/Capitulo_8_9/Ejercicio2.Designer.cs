
namespace Capitulo_8_9
{
    partial class Ejercicio3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NeumaticoTtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Neumaticobutton = new System.Windows.Forms.Button();
            this.NeumaticotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NeumaticoTtextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Neumaticobutton);
            this.groupBox1.Controls.Add(this.NeumaticotextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // NeumaticoTtextBox
            // 
            this.NeumaticoTtextBox.Location = new System.Drawing.Point(141, 68);
            this.NeumaticoTtextBox.Name = "NeumaticoTtextBox";
            this.NeumaticoTtextBox.Size = new System.Drawing.Size(122, 23);
            this.NeumaticoTtextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Neumatico";
            // 
            // Neumaticobutton
            // 
            this.Neumaticobutton.Location = new System.Drawing.Point(105, 114);
            this.Neumaticobutton.Name = "Neumaticobutton";
            this.Neumaticobutton.Size = new System.Drawing.Size(134, 41);
            this.Neumaticobutton.TabIndex = 2;
            this.Neumaticobutton.Text = "ResultadoNeumatico";
            this.Neumaticobutton.UseVisualStyleBackColor = true;
            this.Neumaticobutton.Click += new System.EventHandler(this.Neumaticobutton_Click);
            // 
            // NeumaticotextBox
            // 
            this.NeumaticotextBox.Location = new System.Drawing.Point(141, 39);
            this.NeumaticotextBox.Name = "NeumaticotextBox";
            this.NeumaticotextBox.Size = new System.Drawing.Size(98, 23);
            this.NeumaticotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Neumatico";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NeumaticoTtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Neumaticobutton;
        private System.Windows.Forms.TextBox NeumaticotextBox;
        private System.Windows.Forms.Label label1;
    }
}