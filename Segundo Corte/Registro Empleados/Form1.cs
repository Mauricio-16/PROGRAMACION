using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Empleados
{
    public partial class Form1 : Form
    {
        TextBox txtNombres, txtApellidos, txtEmail, txtIdentificacion;
        ComboBox cmbDepartamento;
        NumericUpDown numSueldoBase;
        Label lblResultado;
        Button btnRegistrar, btnLimpiar;
        ErrorProvider errorProvider;

        public Form1()
        {
            this.Text = "Registro de Empleados";
            this.Width = 400;
            this.Height = 400;

            errorProvider = new ErrorProvider();

            // CONTROLES
            txtNombres = new TextBox() { Top = 20, Left = 150, Width = 200 };
            txtApellidos = new TextBox() { Top = 50, Left = 150, Width = 200 };
            txtEmail = new TextBox() { Top = 80, Left = 150, Width = 200 };
            txtIdentificacion = new TextBox() { Top = 110, Left = 150, Width = 200 };

            numSueldoBase = new NumericUpDown()
            {
                Top = 140,
                Left = 150,
                Minimum = 1000,
                Maximum = 10000,
                Value = 1000
            };

            cmbDepartamento = new ComboBox()
            {
                Top = 170,
                Left = 150,
                Width = 200
            };
            cmbDepartamento.Items.AddRange(new string[] {
                "Ventas", "IT", "Recursos Humanos", "Contabilidad"
            });

            btnRegistrar = new Button()
            {
                Text = "Registrar",
                Top = 210,
                Left = 80
            };

            btnLimpiar = new Button()
            {
                Text = "Limpiar",
                Top = 210,
                Left = 200
            };

            lblResultado = new Label()
            {
                Top = 260,
                Left = 150,
                Width = 200
            };

            // LABELS
            this.Controls.Add(new Label() { Text = "Nombres:", Top = 20, Left = 20 });
            this.Controls.Add(new Label() { Text = "Apellidos:", Top = 50, Left = 20 });
            this.Controls.Add(new Label() { Text = "Email:", Top = 80, Left = 20 });
            this.Controls.Add(new Label() { Text = "Identificación:", Top = 110, Left = 20 });
            this.Controls.Add(new Label() { Text = "Sueldo Base:", Top = 140, Left = 20 });
            this.Controls.Add(new Label() { Text = "Departamento:", Top = 170, Left = 20 });

            // AGREGAR CONTROLES
            this.Controls.Add(txtNombres);
            this.Controls.Add(txtApellidos);
            this.Controls.Add(txtEmail);
            this.Controls.Add(txtIdentificacion);
            this.Controls.Add(numSueldoBase);
            this.Controls.Add(cmbDepartamento);
            this.Controls.Add(btnRegistrar);
            this.Controls.Add(btnLimpiar);
            this.Controls.Add(lblResultado);

            // EVENTOS
            btnRegistrar.Click += Registrar;
            btnLimpiar.Click += Limpiar;
        }

        private void Registrar(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider.SetError(txtNombres, "Campo obligatorio");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Campo obligatorio");
                valido = false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(txtEmail, "Email inválido");
                valido = false;
            }

            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                errorProvider.SetError(txtIdentificacion, "Debe tener 10 dígitos");
                valido = false;
            }

            if (cmbDepartamento.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbDepartamento, "Seleccione un departamento");
                valido = false;
            }

            if (valido)
            {
                decimal sueldo = numSueldoBase.Value;
                decimal neto = sueldo - (sueldo * 0.10m);

                lblResultado.Text = "Sueldo Neto: $" + neto.ToString("N2");
            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();
            cmbDepartamento.SelectedIndex = -1;
            numSueldoBase.Value = 1000;
            lblResultado.Text = "";
            errorProvider.Clear();
        }
    }
}