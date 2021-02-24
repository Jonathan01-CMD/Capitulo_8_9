using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo_8_9
{
    public partial class Menu : System.Windows.Forms.Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Capitulo8button_Click(object sender, EventArgs e)
        {
            Cap8 ejercicio = new Cap8();
            ejercicio.Show(); 
        }

        private void Capitulo9button_Click(object sender, EventArgs e)
        {
            Menu9 menu = new Menu9();
            menu.Show();
        }
    }
}
