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
    public partial class FormConsultaIndividualC : Form
    {
        private AdministraCarreras adCarreras;

        public FormConsultaIndividualC(AdministraCarreras c)
        {
            InitializeComponent();
            adCarreras = c;
        }

        private void FormConsultaIndividualC_Load(object sender, EventArgs e)
        {
            Carrera[] carreras = adCarreras.TotalCarreras();
            cmbNombre.Items.AddRange(carreras);
            cmbNombre.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Carrera carrera = cmbNombre.SelectedItem as Carrera;
                ListViewItem datos = new ListViewItem(carrera.pClave.ToString());
                datos.SubItems.Add(carrera.pNombre);
                if (carrera.pEstatus)
                {
                    datos.SubItems.Add("Activa");
                }
                else
                {
                    datos.SubItems.Add("Inactiva");
                }
                listView1.Items.Add(datos);
            }catch(NullReferenceException)
            {
                MessageBox.Show("Seleccione una Carrera válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbNombre.SelectedIndex = 0;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(FormConsultaIndividualC))
            {
                FormConsultaIndividualC a = (FormConsultaIndividualC)obj;
                if (a.Text == Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
