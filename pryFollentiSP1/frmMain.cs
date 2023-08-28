using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //IMPORTO LA LIBRERIA PARA PODER USAR STREAM


namespace pryFollentiSP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            StreamWriter swCrearArchivo = new StreamWriter("MiArchivito", false); // ASI CREO EL ARCHIVO

            if (swCrearArchivo != null)
            {
                MessageBox.Show("ARCHIVO CREADO");
            }
        }
    }
}
