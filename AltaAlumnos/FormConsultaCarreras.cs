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
    public partial class FormConsultaCarreras : Form
    {
        private AdministraCarreras carreras;
        public FormConsultaCarreras(AdministraCarreras carreras)
        {
            InitializeComponent();
            this.carreras = carreras;
        }

        private void FormConsultaCarreras_Load(object sender, EventArgs e)
        {
            Carrera[] carreras = this.carreras.TotalCarreras();
            for(int i = 0; i < carreras.Length; i++)
            {
                ListViewItem lista = new ListViewItem(carreras[i].pClave.ToString());
                lista.SubItems.Add(carreras[i].pNombre);
                if (carreras[i].pEstatus)
                {
                    lista.SubItems.Add("Activa");
                }
                else
                {
                    lista.SubItems.Add("Inactiva");
                }
                listView1.Items.Add(lista);
            }
        }
    }
}
