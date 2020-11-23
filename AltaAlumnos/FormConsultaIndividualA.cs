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
    public partial class FormConsultaIndividualA : Form
    {
        private AdministraAlumnos alumnos;
        private AdministraCarreras carreras;

        public FormConsultaIndividualA(AdministraAlumnos a, AdministraCarreras c)
        {
            InitializeComponent();
            alumnos = a;
            carreras = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Consultar())
            {
                MessageBox.Show("Alumno no agregado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtDato, "Ingrese nombre o No. Control.");
            }
            else
            {
                errorProvider1.SetError(txtDato, "");
            }
        }

        private void FormConsultaIndividualA_Load(object sender, EventArgs e)
        {
            
            txtDato.AutoCompleteCustomSource = CargarDatos();
        }

        private AutoCompleteStringCollection CargarDatos()
        {
            string[] d = alumnos.ClavesNombres();
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            datos.AddRange(d);
            return datos;
        }

        private bool Consultar()
        {
            dataGridView1.Rows.Clear();
            try
            {
                long clave = Convert.ToInt64(txtDato.Text);
                if (alumnos.EstaClave(clave))
                {
                    Alumno a = alumnos.AlumnoClave(clave);
                    dataGridView1.Rows.Add(clave, a.pNombre, carreras.NombreCarrera(a.pCarrera), a.pDomicilio, a.pEdad);
                    return true;
                }
                else
                {
                    return false;
                }

            }catch(FormatException)
            {
                string nombre = txtDato.Text.ToUpper();
                txtDato.Text = nombre;
                string[] datos = alumnos.DatosAlumnoNombre(nombre, carreras);
                if (datos[0] == null)
                {
                    return false;
                }
                else
                {
                    dataGridView1.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                    return true;
                }
            }
        }

        private void txtDato_Validated(object sender, EventArgs e)
        {
            if (Validaciones.ValidaBlanco(txtDato.Text))
            {
                errorProvider1.SetError(txtDato, "Ingrese nombre o No. Control.");
            }
            else
            {
                errorProvider1.SetError(txtDato, "");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(FormConsultaIndividualA))
            {
                FormConsultaIndividualA a = (FormConsultaIndividualA)obj;
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
