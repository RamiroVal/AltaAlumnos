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
    public partial class FormMenu : Form
    {
        private Form formActivo;
        private AdministraAlumnos alumnos;
        private AdministraCarreras carreras;

        public FormMenu()
        {
            InitializeComponent();
            formActivo = null;
        }

        private void OcultaSubMenu()
        {
            if (panelSubAlumnos.Visible == true)
                panelSubAlumnos.Visible = false;
            if (panelSubCarrera.Visible == true)
                panelSubCarrera.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultaSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Botones Principal
        private void btnCarreras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubCarrera);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubAlumnos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Botones Carrera
        private void btnAgregaC_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            FormAltaCarreras altaCarreras = new FormAltaCarreras(carreras);
            lblTitulo.Text = altaCarreras.Text;
            AbrirFormsHijos(altaCarreras);
        }

        private void btnIndividualC_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            if (carreras.pHayCarreras)
            {
                FormConsultaIndividualC c = new FormConsultaIndividualC(carreras);
                lblTitulo.Text = c.Text;
                AbrirFormsHijos(c);
            }
            else
            {
                MessageBox.Show("No se han agregado Carreras.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnConsultaC_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            if (carreras.pHayCarreras)
            {
                FormConsultaCarreras consulta = new FormConsultaCarreras(carreras);
                lblTitulo.Text = consulta.Text;
                AbrirFormsHijos(consulta);
            }
            else
            {
                MessageBox.Show("No se han agregado Carreras.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Botones Alumno
        private void btnAgregaA_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            if (!carreras.pHayActivas)
            {
                MessageBox.Show("No hay Carreras activas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                formPrincipal agregaAlumnos = new formPrincipal(alumnos, carreras);
                lblTitulo.Text = agregaAlumnos.Text;
                AbrirFormsHijos(agregaAlumnos);
            }
        }

        private void btnIndividualA_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            if (alumnos.pHayAlumnos)
            {
                FormConsultaIndividualA con = new FormConsultaIndividualA(alumnos, carreras);
                lblTitulo.Text = con.Text;
                AbrirFormsHijos(con);
            }
            else
            {
                MessageBox.Show("No se han agregado Alumnos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            if (!alumnos.pHayAlumnos)
            {
                MessageBox.Show("No se han agregado Alumnos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormConsultaAlumnos consultaAlumnos = new FormConsultaAlumnos(alumnos, carreras);
                lblTitulo.Text = consultaAlumnos.Text;
                AbrirFormsHijos(consultaAlumnos);
            }
        }
        #endregion

        private void picLogo_Click(object sender, EventArgs e)
        {
            OcultaSubMenu();
            if (formActivo != null)
            {
                formActivo.Close();
                lblTitulo.Text = "HOME";
            }
        }

        private void AbrirFormsHijos(Form formHijo)
        {
            if (formActivo == null)
            {
                formActivo = formHijo;
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formHijo);
                panelContenedor.Tag = formHijo;
                formHijo.BringToFront();
                formHijo.Show();
            }
            else
            {
                if (formActivo.Equals(formHijo))
                {
                    return;
                }
                else
                {
                    if (formActivo != null)
                    {
                        formActivo.Close();
                    }
                    formActivo = formHijo;
                    formHijo.TopLevel = false;
                    formHijo.FormBorderStyle = FormBorderStyle.None;
                    formHijo.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(formHijo);
                    panelContenedor.Tag = formHijo;
                    formHijo.BringToFront();
                    formHijo.Show();
                }
            }
            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            alumnos = new AdministraAlumnos();
            carreras = new AdministraCarreras();
        }
    }
}
