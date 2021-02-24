using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capitulo_8_9
{
    public partial class Cap9 : Form
    {
        public Cap9()
        {
            InitializeComponent();
        }

        public struct Productos
        {
            public double precio;
            public string Nombre_producto;
            public int Cantidad;

            public Productos(string nombre, int cant, double preci)
            {
                Nombre_producto = nombre;
                Cantidad = cant;
                precio = preci;
            }
        }

        private void Compararbutton_Click(object sender, EventArgs e)
        {
            string nombre = ProductotextBox.Text;
            int cant = Convert.ToInt32(CantidadtextBox.Text);
            double preci = Convert.ToDouble(PreciotextBox.Text);

            Productos product = new Productos(nombre, cant, preci);

            MessageBox.Show("Guardado correctamente");
        }
    }
}
