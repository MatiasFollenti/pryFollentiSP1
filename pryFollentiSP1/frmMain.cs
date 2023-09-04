using System;
using System.IO; //IMPORTO LA LIBRERIA PARA PODER USAR STREAM
using System.Windows.Forms;


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
