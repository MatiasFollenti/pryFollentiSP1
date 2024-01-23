using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace pryFollentiSP1
{
    public partial class frmConsultaRep : Form
    {
        private string rutaArchivo;
        public frmConsultaRep(string Ruta)
        {
            InitializeComponent();
            rutaArchivo = Ruta;
            Inicializar();
        }

        public void Inicializar() 
        {
            // carga de los items en el comboBox de Marcas
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Honda");
            cmbMarca.Items.Add("Yamaha");
            cmbMarca.Items.Add("Kawasaki");
            cmbMarca.Items.Add("Suzuki");
            cmbMarca.SelectedIndex = 0;
            // opción de Origen inicial
            optNacional.Checked = true;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // controlar si el archivo existe
            if (!File.Exists(Application.StartupPath + "\\" + rutaArchivo))
            {
                MessageBox.Show("No hay datos para mostrar", "Consulta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // leer el contenido del archivo
            Archivo Repuestos = new Archivo();
            Repuestos.NombreArchivo = rutaArchivo;
            List<Repuesto> repuestos = Repuestos.ObtenerRepuestosOrdenados();
            // limpiar la grilla
            dgvRepuestos.Rows.Clear();
            // recorrer la lista de repuestos
            foreach (Repuesto repuesto in repuestos)
            {
                // controlar el valor de la Marca
                if (repuesto.marca == cmbMarca.SelectedItem.ToString())
                {
                    // controlar el tipo de Origen y los botones de opción activos
                    if (optImp.Checked && repuesto.origen == "Importado")
                    {
                        // agregar el repuesto a la grilla
                        dgvRepuestos.Rows.Add(repuesto.codigo, repuesto.nombre,
                        repuesto.marca, repuesto.origen,
                        repuesto.precio.ToString());
                    }
                    else
                    {
                        if (optNacional.Checked && repuesto.origen == "Nacional")
                        {
                            // agregar el repuesto a la grilla
                            dgvRepuestos.Rows.Add(repuesto.codigo, repuesto.nombre,
                            repuesto.marca, repuesto.origen,
                            repuesto.precio.ToString());
                        }
                        else
                        {
                            if (optAmbos.Checked)
                            {
                                // agregar el repuesto a la grilla
                                dgvRepuestos.Rows.Add(repuesto.codigo, repuesto.nombre,
                                repuesto.marca, repuesto.origen,
                                repuesto.precio.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void frmConsultaRep_Load(object sender, EventArgs e)
        {

        }
    }
}
