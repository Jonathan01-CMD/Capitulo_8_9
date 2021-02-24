using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulo_8_9
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        enum Neumaticos
        {
            Asimetrico = 1, 
            Diagonales, 
            Tubuless,
            Invierno, 
            Ecologicos, 
            Radiales,
            ReCauchutados,
            Verano, 
            PerfilBajo, 
            TodoTerreno,
            Direccionales
        }
        private void Neumaticobutton_Click(object sender, EventArgs e)
        {

            Neumaticos neumatico = Neumaticos.Asimetrico;
            int opcion = Convert.ToInt32(NeumaticotextBox.Text);

            switch (opcion)
            {
                case 1:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Asimetrico);
                    break;

                case 2:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Diagonales);
                    break;

                case 3:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Tubuless);
                    break;

                case 4:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Invierno);
                    break;

                case 5:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Ecologicos);
                    break;

                case 6:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Radiales);
                    break;

                case 7:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.ReCauchutados);
                    break;

                case 8:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Verano);
                    break;

                case 9:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.PerfilBajo);
                    break;

                case 10:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.TodoTerreno);
                    break;
                case 11:
                    NeumaticoTtextBox.Text = Convert.ToString(Neumaticos.Direccionales);
                    break;

                default:
                    MessageBox.Show("Solo tenemos 11 tipos de neumaticos", "XXX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
