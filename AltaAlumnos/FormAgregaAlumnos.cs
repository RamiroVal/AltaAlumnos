﻿using System;
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
    /// <summary>
    /// Form para dar de alta alumnos.
    /// </summary>
    public partial class formPrincipal : Form
    {
        private AdministraAlumnos alumnos;
        private AdministraCarreras carreras;
        public formPrincipal( AdministraAlumnos alumnos, AdministraCarreras carreras)
        {
            InitializeComponent();
            this.alumnos = alumnos;
            this.carreras = carreras;
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
            long numControl = Convert.ToInt64(txtNoControl.Text);
            string nombre = txtNombre.Text;
            string carrera = cmbCarreras.SelectedItem.ToString();
            int edad = Convert.ToInt32(numEdad.Value);
            string domicilio = txtDomicilio.Text;

            if (Validaciones.ValidaBlanco(nombre) || Validaciones.ValidaBlanco(domicilio))
            {
                if(Validaciones.ValidaBlanco(nombre) && Validaciones.ValidaBlanco(domicilio))
                {
                    MessageBox.Show("Agregue nombre y domicilio para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txtNombre, "Agregue nombre");
                    errorProvider1.SetError(txtDomicilio, "Agregue domicilio");
                }
                else
                {
                    if (Validaciones.ValidaBlanco(nombre))
                    {
                        MessageBox.Show("Agregue nombre para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtNombre, "Agregue nombre");
                    }
                    if (Validaciones.ValidaBlanco(domicilio))
                    {
                        MessageBox.Show("Agregue domicilio para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtDomicilio, "Agregue domicilio");
                    }
                }
            }
            else
            {
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
            Carrera[] carreras = this.carreras.CarrerasActivas();
            cmbCarreras.Items.AddRange(carreras);
            cmbCarreras.SelectedIndex = 0;
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FormConsultaAlumnos consulta = new FormConsultaAlumnos(alumnos);
            consulta.ShowDialog();
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
                errorProvider1.SetError(txtNombre, "Solo letras.");
                e.Handled = true;
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (Validaciones.ValidaBlanco(nombre))
            {
                errorProvider1.SetError(txtNombre, "Agregue nombre.");
            }
        }

        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            string domicilio = txtDomicilio.Text;
            if (Validaciones.ValidaBlanco(domicilio))
            {
                errorProvider1.SetError(txtDomicilio, "Agregue Domicilio.");
            }
            else
            {
                errorProvider1.SetError(txtDomicilio, "");
            }
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtDomicilio, "");
        }
    }
}
