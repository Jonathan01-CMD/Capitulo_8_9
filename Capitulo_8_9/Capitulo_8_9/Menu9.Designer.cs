
namespace Capitulo_8_9
{
    partial class Menu9
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
            this.ejercicio4button = new System.Windows.Forms.Button();
            this.Ejercicio1button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ejercicio4button);
            this.groupBox1.Controls.Add(this.Ejercicio1button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // ejercicio4button
            // 
            this.ejercicio4button.Location = new System.Drawing.Point(65, 77);
            this.ejercicio4button.Name = "ejercicio4button";
            this.ejercicio4button.Size = new System.Drawing.Size(89, 30);
            this.ejercicio4button.TabIndex = 1;
            this.ejercicio4button.Text = "Ejercicio4";
            this.ejercicio4button.UseVisualStyleBackColor = true;
            this.ejercicio4button.Click += new System.EventHandler(this.ejercicio4button_Click);
            // 
            // Ejercicio1button
            // 
            this.Ejercicio1button.Location = new System.Drawing.Point(65, 41);
            this.Ejercicio1button.Name = "Ejercicio1button";
            this.Ejercicio1button.Size = new System.Drawing.Size(89, 30);
            this.Ejercicio1button.TabIndex = 0;
            this.Ejercicio1button.Text = "Ejercicio1";
            this.Ejercicio1button.UseVisualStyleBackColor = true;
            this.Ejercicio1button.Click += new System.EventHandler(this.Ejercicio1button_Click);
            // 
            // Menu9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 150);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu9";
            this.Text = "Menu 9";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ejercicio4button;
        private System.Windows.Forms.Button Ejercicio1button;
    }
}