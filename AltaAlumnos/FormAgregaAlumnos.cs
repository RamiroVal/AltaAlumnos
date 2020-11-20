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
        private AdministraCarreras carreras;
        public formPrincipal()
        {
            InitializeComponent();
            alumnos = new AdministraAlumnos();
        }

        /// <summary>
        /// Método que se activa al dar click sobre el botón btnLimpiar
        /// que llama al método Limpiar.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Método que limpia los campos de Texto.
        /// </summary>
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            numEdad.Value = 16;
            cmbCarreras.SelectedIndex = 0;
        }

        /// <summary>
        /// Método que se activa al presionar el botón btnGuardar
        /// comprueba si todos los parámetros para guardar un objeto
        /// de tipo Alumno se han introducido correctamente
        /// y de ser así, los manda a guardar.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string domicilio = txtDomicilio.Text;

            if (CampoVacio(nombre) || CampoVacio(domicilio))
            {
                MessageBox.Show("Datos no válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long numControl = Convert.ToInt64(txtNoControl.Text);
                string carrera = cmbCarreras.SelectedItem.ToString();
                int edad = Convert.ToInt32(numEdad.Value);

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

        /// <summary>
        /// Método Load, se ejecuta cuando Form se carga.
        /// </summary>
        private void formPrincipal_Load(object sender, EventArgs e)
        {
            txtNoControl.Text = alumnos.CalculaNumControl();
            Carrera[] carreras = 
            //cmbCarreras.Items.AddRange
            //cmbCarreras.SelectedIndex = 0;
        }

        /// <summary>
        /// Método Click del botón btnConsultar, invoca un Form
        /// modal con todos los alumnos que han sido agregados.
        /// </summary>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormConsultaAlumnos consulta = new FormConsultaAlumnos(alumnos);
            consulta.ShowDialog();
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (CampoVacio(nombre))
            {
                errorP.SetError(txtNombre, "Capo vacío");
                txtNombre.Focus();
            }
            else
            {
                errorP.SetError(txtNombre, "");
            }
        }

        

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        #region Validaciones
        private bool CampoVacio(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) || string.IsNullOrWhiteSpace(cadena))
            {
                return true;
            }
            return false;
        }

        /*private bool ValidaNombre(string nombre)
        {
            if(string.)
        }*/
        #endregion
    }
}
