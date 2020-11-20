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
    public partial class FormConsultaAlumnos : Form
    {
        private AdministraAlumnos adAlumnos;
        public FormConsultaAlumnos(AdministraAlumnos ad)
        {
            InitializeComponent();
            adAlumnos = ad;
        }

        private void frmConsultaAlumnos_Load(object sender, EventArgs e)
        {
            string[,] alumnos = adAlumnos.ConsultaAlumnos();
            
            for(int i = 0; i < alumnos.GetLength(0); i++)
            {
                gridAlumnos.Rows.Add(alumnos[i, 0], alumnos[i, 1], alumnos[i, 2], alumnos[i, 3], alumnos[i, 4]);
            }
        }
    }
}
