using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestión_de_Inventario__CSV_
{
    public partial class Form1 : Form
    {
        string ruta = "productos.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string codigo = txtCodigo.Text;
            int costo = (int)numCosto.Value;
            int cantidad = (int)numCantidad.Value;

            string linea = nombre + "," + codigo + "," + costo + "," + cantidad;

            File.AppendAllText(ruta, linea + Environment.NewLine);

            txtNombre.Clear();
            txtCodigo.Clear();
            numCosto.Value = 0;
            numCantidad.Value = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    listBox1.Items.Add(linea);
                }
            }
        }
    }
}