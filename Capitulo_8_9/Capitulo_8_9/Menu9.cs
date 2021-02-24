using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulo_8_9
{
    public partial class Menu9 : Form
    {
        public Menu9()
        {
            InitializeComponent();
        }

        private void Ejercicio1button_Click(object sender, EventArgs e)
        {
            Cap9 ejercicio1 = new Cap9();
            ejercicio1.Show();
        }

        private void ejercicio4button_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }
    }
}
