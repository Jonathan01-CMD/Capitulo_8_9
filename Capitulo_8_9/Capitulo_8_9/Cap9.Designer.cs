
namespace Capitulo_8_9
{
    partial class Cap9
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
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.ProductotextBox = new System.Windows.Forms.TextBox();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Productolabel = new System.Windows.Forms.Label();
            this.Compararbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(134, 94);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(182, 23);
            this.PreciotextBox.TabIndex = 11;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(134, 56);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(182, 23);
            this.CantidadtextBox.TabIndex = 10;
            // 
            // ProductotextBox
            // 
            this.ProductotextBox.Location = new System.Drawing.Point(134, 19);
            this.ProductotextBox.Name = "ProductotextBox";
            this.ProductotextBox.Size = new System.Drawing.Size(182, 23);
            this.ProductotextBox.TabIndex = 9;
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(88, 94);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(40, 15);
            this.Preciolabel.TabIndex = 8;
            this.Preciolabel.Text = "Precio";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(42, 56);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(55, 15);
            this.Cantidadlabel.TabIndex = 7;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Productolabel
            // 
            this.Productolabel.AutoSize = true;
            this.Productolabel.Location = new System.Drawing.Point(6, 19);
            this.Productolabel.Name = "Productolabel";
            this.Productolabel.Size = new System.Drawing.Size(122, 15);
            this.Productolabel.TabIndex = 6;
            this.Productolabel.Text = "Nombre del producto";
            // 
            // Compararbutton
            // 
            this.Compararbutton.Location = new System.Drawing.Point(134, 123);
            this.Compararbutton.Name = "Compararbutton";
            this.Compararbutton.Size = new System.Drawing.Size(97, 31);
            this.Compararbutton.TabIndex = 12;
            this.Compararbutton.Text = "Guardar";
            this.Compararbutton.UseVisualStyleBackColor = true;
            this.Compararbutton.Click += new System.EventHandler(this.Compararbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PreciotextBox);
            this.groupBox1.Controls.Add(this.Compararbutton);
            this.groupBox1.Controls.Add(this.CantidadtextBox);
            this.groupBox1.Controls.Add(this.ProductotextBox);
            this.groupBox1.Controls.Add(this.Preciolabel);
            this.groupBox1.Controls.Add(this.Cantidadlabel);
            this.groupBox1.Controls.Add(this.Productolabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 163);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // Cap9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 186);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cap9";
            this.Text = "Cap9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox ProductotextBox;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Label Productolabel;
        private System.Windows.Forms.Button Compararbutton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}