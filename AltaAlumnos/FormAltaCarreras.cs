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

        #region Eventos Click
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            errorProvider1.SetError(txtClave, "");
            errorProvider1.SetError(txtNombre, "");
        }
        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (adCarreras.pHayCarreras)
            {
                errorProvider1.SetError(txtClave, "");
                errorProvider1.SetError(txtNombre, "");
                FormConsultaCarreras consulta = new FormConsultaCarreras(adCarreras);
                consulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han añadido carreras, agregue una para continuar", "Sin carreras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos Validated
        private void txtClave_Validated(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            if (Validaciones.ValidaBlanco(clave))
            {
                errorProvider1.SetError(txtClave, "Agregue clave");
            }
            else
            {
                errorProvider1.SetError(txtClave, "");
            }
            if(clave.Length == 4)
            {
                errorProvider1.SetError(txtClave, "");
            }
            else
            {
                errorProvider1.SetError(txtClave, "Clave de 4 caracteres");
            }
        }
        
        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (Validaciones.ValidaBlanco(nombre))
            {
                errorProvider1.SetError(txtNombre, "Agregue clave");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }
        }
        #endregion

        #region Eventos KeyPress
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validaciones.ValidaClave(e.KeyChar))
            {
                errorProvider1.SetError(txtClave, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtClave, "Solo números");
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                Guardar();
                errorProvider1.SetError(txtClave, "");
            }
        }
        
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validaciones.ValidaNombre(e.KeyChar))
            {
                errorProvider1.SetError(txtNombre, "");
                e.Handled = false;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "Solo letras");
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                Guardar();
                errorProvider1.SetError(txtNombre, "");
            }
        }
        
        private void rbtActiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Guardar();
                errorProvider1.SetError(txtNombre, "");
                errorProvider1.SetError(txtClave, "");
            }
        }
        
        private void btInactiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Guardar();
                errorProvider1.SetError(txtNombre, "");
                errorProvider1.SetError(txtClave, "");
            }
        }
        #endregion

        #region Utilidades
        /// <summary>
        /// Método para mandar a guardar los datos que el usario ingresó.
        /// </summary>
        private void Guardar()
        {
            try
            {
                long clave = Convert.ToInt64(txtClave.Text);
                string nombre = txtNombre.Text.ToUpper();
                bool estatus = rbtActiva.Checked;
                if (Validaciones.ValidaBlanco(clave.ToString()) || Validaciones.ValidaBlanco(nombre))
                {
                    if (Validaciones.ValidaBlanco(clave.ToString()) && Validaciones.ValidaBlanco(nombre))
                    {
                        MessageBox.Show("Agregue Clave y nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtClave, "Ingrese clave");
                        errorProvider1.SetError(txtNombre, "Ingrese nombre");
                    }
                    else
                    {
                        if (Validaciones.ValidaBlanco(clave.ToString()))
                        {
                            MessageBox.Show("Agregue clave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            errorProvider1.SetError(txtClave, "Ingrese clave");
                        }
                        if (Validaciones.ValidaBlanco(nombre))
                        {
                            MessageBox.Show("Agregue nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            errorProvider1.SetError(txtNombre, "Ingrese nombre");
                        }
                    }
                }
                else
                {
                    if(txtClave.Text.Length == 4)
                    {
                        errorProvider1.SetError(txtClave, "");
                        string status = "";
                        if (estatus)
                        {
                            status = "Activa";
                        }
                        else
                        {
                            status = "Inactiva";
                        }

                        DialogResult resultado = MessageBox.Show("Se agregará la carrera:" +
                            $"\nClave: {clave}" +
                            $"\nNombre: {nombre}" +
                            $"\nEstatus: {status}", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if ((resultado == DialogResult.Yes))
                        {
                            if (adCarreras.AgregaCarrera(clave, nombre, estatus))
                            {
                                MessageBox.Show($"La carrera {nombre} ha sido agregada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                rbtActiva.Select();
                                txtClave.Focus();
                            }
                            else
                            {
                                MessageBox.Show($"No se pudo agregar la carrera {nombre} ya que se encuentra repetida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La clave tiene que ser de cuatro caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtClave, "Clave de 4 caracteres");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtClave, "Ingrese clave");
            }
        }

        /// <summary>
        /// Método para limpiar los TextArea.
        /// </summary>
        private void Limpiar()
        {
            txtClave.Clear();
            txtNombre.Clear();
        }
        #endregion


    }
}
