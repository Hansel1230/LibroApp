using BusinesLayer;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LibroApp
{
    public partial class FomMantAutores : Form
    {
        #region Instancia
        public static FomMantAutores Instancia { get; } = new FomMantAutores();
        #endregion

        #region variables
        private int AutorId { get; set; } = 0;
        private BibliotecaService service;
        private bool isvalid;
        #endregion


        public FomMantAutores()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            service = new BibliotecaService(connection);
        }

        #region Eventos
        private void FomMantAutores_Load(object sender, EventArgs e)
        {

            FullTxt();

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (TxtNombre.Text== "Ingrese Nombre:")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                isvalid = false;
            }
            else if (TxtApellido.Text == "Ingrese Apellido:")
            {
                MessageBox.Show("Debe ingresar un Apellido");
                isvalid = false;
            }
            else if (TxtCorreo.Text == "Ingrese Correo:")
            {
                MessageBox.Show("Debe ingresar un Correo");
                isvalid = false;
            }
            if (isvalid)
            {
                Database.Modelos.Autor autor = new Database.Modelos.Autor(TxtNombre.Text, TxtApellido.Text, TxtCorreo.Text);

                if (AutorId>0)
                {
                    service.EditarAutor(autor, AutorId);
                    AutorId = 0;
                }
                else
                {
                    service.AgregarAutor(autor);
                }

                FullTxt();
                FomDataGridView.Instancia.LoadData();
                FomDataGridView.Instancia.Show();
                Instancia.Hide();
            }
        }
        //Mantenimiento TxtNombre.Text
        private void TxtNombre_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "Ingrese Nombre:")
            {
                TxtNombre.Text = "";
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                TxtNombre.Text = "Ingrese Nombre:";
            }
        }
        //Mantenimiento Txt.Apellido.Text
        private void TxtApellido_Click(object sender, EventArgs e)
        {
            if (TxtApellido.Text== "Ingrese Apellido:")
            {
                TxtApellido.Text = "";
            }
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (TxtApellido.Text == "")
            {
                TxtApellido.Text = "Ingrese Apellido:";
            }
        }

        //Mantenimiento TxtCorreo.Text
        private void TxtCorreo_Click(object sender, EventArgs e)
        {
            if (TxtCorreo.Text== "Ingrese Correo:")
            {
                TxtCorreo.Text = "";
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "")
            {
                TxtCorreo.Text = "Ingrese Correo:";
            }
        }

        private void atrsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FomDataGridView.Instancia.Show();
            Instancia.Hide();
        }
        private void FomMantAutores_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Metodos

        public void FullTxt()
        {
            TxtNombre.Text = "Ingrese Nombre:";
            TxtApellido.Text = "Ingrese Apellido:";
            TxtCorreo.Text = "Ingrese Correo:";
        }

        public void LoadTxt()
        {
            if (FomDataGridView.Instancia.FilaSeleccionada != null)
            {
                AutorId = Convert.ToInt16(FomDataGridView.Instancia.FilaSeleccionada.Cells[0].Value);
                TxtNombre.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[1].Value.ToString();
                TxtApellido.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[2].Value.ToString();
                TxtCorreo.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[3].Value.ToString();
                FomDataGridView.Instancia.FilaSeleccionada = null;
            }
        }
        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
