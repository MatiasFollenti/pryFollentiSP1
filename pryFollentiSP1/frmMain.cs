using System;
using System.IO; //IMPORTO LA LIBRERIA PARA PODER USAR STREAM
using System.Windows.Forms;


namespace pryFollentiSP1
{
    public partial class frmMain : Form
    {

        private const string RutaArchivo = "Repuestos.txt";
        public frmMain()
        {
            InitializeComponent();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            txtNombre.Text = "";
            txtCodigo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            cmbMarca.Items.Clear();
            cmbMarca.Items.Add("Honda");
            cmbMarca.Items.Add("Yamaha");
            cmbMarca.Items.Add("Kawasaki");
            cmbMarca.Items.Add("Suzuki");
           
            optNacional.Checked = true;

        }
        private bool ValidarDatos()
        {
            // devuelve falso si no se cumplen todas las condiciones
            bool resultado = false;
            if (txtCodigo.Text != "") // controla el valor del código
            {
                if (txtNombre.Text != "") // controla el nombre
                {
                    if (txtPrecio.Text != "") // controla el precio
                    {
                        Archivo ArchRepuestos = new Archivo();
                        ArchRepuestos.NombreArchivo = RutaArchivo;
                        // controla que no se repita el codigo del repuesto
                        if (ArchRepuestos.BuscarCodigoRepuesto(txtCodigo.Text) == false)
                        {
                            resultado = true; // devuelve verdadero sólo si todas
                                              // las condiciones se cumplieron
                        }
                    }
                }
            }
            return resultado;
        }

        private Repuesto CrearRepuesto()
        {
            // se crea un nuevo objeto de tipo Repuesto
            Repuesto nuevoRep = new Repuesto();
            // se asignan los valores a todas sus propiedades
            nuevoRep.codigo = txtCodigo.Text;
            nuevoRep.nombre = txtNombre.Text;
            nuevoRep.marca = cmbMarca.SelectedItem.ToString();
            nuevoRep.precio = decimal.Parse(txtPrecio.Text);
            if (optNacional.Checked)
            {
                nuevoRep.origen = "Nacional";
            }
            else
            {
                nuevoRep.origen = "Importado";
            }
            return nuevoRep; // devuelve el objeto creado con sus valores
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // aceptar solo expresiones numéricas con decimales
            if (!Char.IsNumber(e.KeyChar) &&
            e.KeyChar != ',' && e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtPrecio.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()) // si los datos son correctos
            {
                // crear un nuevo repuesto
                Repuesto nuevoRep = CrearRepuesto();
                // grabar en el archivo
                Archivo ArchRepuestos = new Archivo();
                ArchRepuestos.NombreArchivo = RutaArchivo;
                ArchRepuestos.GrabarRepuestos(nuevoRep);
                MessageBox.Show("Repuesto grabado con éxito!");
                // restaurar la interfaz al estado inicial
                Inicializar();
            }
            else // si hay algún error
            {
                MessageBox.Show("Datos incorrectos", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaRep frmConsultaRep = new frmConsultaRep(RutaArchivo);
            this.Hide();
            frmConsultaRep.Show();
            
        }
    }
}
