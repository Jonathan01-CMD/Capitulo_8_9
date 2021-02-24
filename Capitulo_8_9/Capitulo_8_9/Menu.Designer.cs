
namespace Capitulo_8_9
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Capitulo9button = new System.Windows.Forms.Button();
            this.Capitulo8button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Capitulo9button);
            this.groupBox1.Controls.Add(this.Capitulo8button);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Capitulo9button
            // 
            this.Capitulo9button.Location = new System.Drawing.Point(147, 22);
            this.Capitulo9button.Name = "Capitulo9button";
            this.Capitulo9button.Size = new System.Drawing.Size(107, 50);
            this.Capitulo9button.TabIndex = 1;
            this.Capitulo9button.Text = "Cap 9";
            this.Capitulo9button.UseVisualStyleBackColor = true;
            this.Capitulo9button.Click += new System.EventHandler(this.Capitulo9button_Click);
            // 
            // Capitulo8button
            // 
            this.Capitulo8button.Location = new System.Drawing.Point(6, 22);
            this.Capitulo8button.Name = "Capitulo8button";
            this.Capitulo8button.Size = new System.Drawing.Size(107, 50);
            this.Capitulo8button.TabIndex = 0;
            this.Capitulo8button.Text = "Cap 8";
            this.Capitulo8button.UseVisualStyleBackColor = true;
            this.Capitulo8button.Click += new System.EventHandler(this.Capitulo8button_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(287, 124);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Capitulo9button;
        private System.Windows.Forms.Button Capitulo8button;
    }
}

