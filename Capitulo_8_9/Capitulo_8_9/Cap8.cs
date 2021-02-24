using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulo_8_9
{
    public partial class Cap8 : Form
    {
        public Cap8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            horatextBox.Text = hora.ToString("hh:mm tt");
        }

        private void Ordenbutton_Click(object sender, EventArgs e)
        {
            int compare;
            string cadena, cadena2;
            cadena = CadenatextBox.Text;
            cadena2 = Cadena2textBox.Text;

            compare = cadena.CompareTo(cadena2);
            if(compare == 0)
            {
                MessageBox.Show("Son iguales");
            }
            else
            {
                if(compare < 0)
                {
                    MessageBox.Show(cadena + "\n" + cadena2);
                }
                else
                {
                    MessageBox.Show(cadena2 + "\n" + cadena);
                }
            }
        }
    }
}
