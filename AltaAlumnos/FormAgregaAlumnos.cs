using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltaAlumnos
{
    public partial class formPrincipal : Form
    {
        private AdministraAlumnos alumnos;
        public formPrincipal()
        {
            InitializeComponent();
            alumnos = new AdministraAlumnos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            numEdad.Value = 16;
            cmbCarreras.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDomicilio.Text == "")
            {
                MessageBox.Show("Campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long numControl = Convert.ToInt64(txtNoControl.Text);
                string nombre = txtNombre.Text;
                string carrera = cmbCarreras.SelectedItem.ToString();
                int edad = Convert.ToInt32(numEdad.Value);
                string domicilio = txtDomicilio.Text;

                DialogResult resultado = MessageBox.Show("Se agregará al alumno:" +
                    $"\nNombre: {nombre}" +
                    $"\nCarrera: {carrera}" +
                    $"\nEdad: {edad}" +
                    $"\nDomicilio: {txtDomicilio.Text}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    if (alumnos.AgregaAlumno(numControl, nombre, domicilio, carrera, edad))
                    {
                        MessageBox.Show($"El alumno {nombre} ha sido agregado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        txtNoControl.Text = alumnos.CalculaNumControl();
                    }
                    else
                    {
                        MessageBox.Show($"No se ha podido añadir al alumno {nombre}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            txtNoControl.Text = alumnos.CalculaNumControl();
            cmbCarreras.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormConsultaAlumnos consulta = new FormConsultaAlumnos(alumnos);
            consulta.ShowDialog();
        }
    }
}
