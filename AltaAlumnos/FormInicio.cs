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
    public partial class FormInicio : Form
    {
        private AdministraAlumnos alumnos;
        private AdministraCarreras carreras;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            alumnos = new AdministraAlumnos();
            carreras = new AdministraCarreras();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaCarreras altaCarreras = new FormAltaCarreras(carreras);
            altaCarreras.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!carreras.pHayActivas)
            {
                MessageBox.Show("No hay materias activas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                formPrincipal agregaAlumnos = new formPrincipal(alumnos, carreras);
                agregaAlumnos.ShowDialog();
            }
        }

        private void todoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(!alumnos.pHayAlumnos)
            {
                MessageBox.Show("No se han agregado Alumnos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormConsultaAlumnos consultaAlumnos = new FormConsultaAlumnos(alumnos, carreras);
                consultaAlumnos.ShowDialog();
            }
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (carreras.pHayCarreras)
            {
                FormConsultaCarreras consulta = new FormConsultaCarreras(carreras);
                consulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han agregado Materias.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
