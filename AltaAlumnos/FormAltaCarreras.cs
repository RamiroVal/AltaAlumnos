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
    public partial class FormAltaCarreras : Form
    {
        private AdministraCarreras adCarreras;
        public FormAltaCarreras()
        {
            InitializeComponent();
            adCarreras = new AdministraCarreras();
        }

        private void rbtActiva_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            long clave = Convert.ToInt64(txtClave.Text);
            string nombre = txtNombre.Text;
            string estatus = "Activa";
            if(adCarreras.AgregaCarrera(clave, nombre, estatus))
            {
                MessageBox.Show($"La carrera {nombre}, se ha agregado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"La carrera {nombre}, ya ha sido agregada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
