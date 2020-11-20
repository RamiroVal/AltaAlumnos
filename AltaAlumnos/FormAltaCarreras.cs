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
        public FormAltaCarreras(AdministraCarreras carreras)
        {
            InitializeComponent();
            adCarreras = carreras;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            long clave;
            string nombre;
            bool estatus;
            try
            {
                clave = Convert.ToInt64(txtClave.Text);
                nombre = txtNombre.Text;
                estatus = rbtActiva.Checked;
            }
            catch (Exception ex)
            {
                return;
            }
            
            

            if(adCarreras.AgregaCarrera(clave, nombre, estatus))
            {
                MessageBox.Show($"La carrera {nombre}, se ha agregado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"La carrera {nombre} o la clave {clave}, ya han sido agregadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
