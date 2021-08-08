using BusinesLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibroApp
{
    public sealed partial class FomPantallaPrincipal : Form
    {
        #region Instancia
        public static FomPantallaPrincipal Instancia { get; } = new FomPantallaPrincipal();
        #endregion

        public string TipoMantenimiento { get; set; }
        private BibliotecaService service;

        private FomPantallaPrincipal()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            service = new BibliotecaService(connection);
        }

        #region Eventos
        private void BtnEditoriales_Click(object sender, EventArgs e)
        {
            TipoMantenimiento = "Editoriales";
            moverADGV();

        }
        private void BtnAutores_Click(object sender, EventArgs e)
        {
            TipoMantenimiento = "Autores";
            moverADGV();
        }
        private void BtnLibros_Click(object sender, EventArgs e)
        {
            if (service.ValidarLibro())
            {
                TipoMantenimiento = "Libros";
                moverADGV();
            }
            else
            {
                MessageBox.Show("Debe Ingresar Autores y/o Editoriales para poder continuar");
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        #endregion

        #region Metodos

        private void moverADGV()
        {
            FomDataGridView.Instancia.LoadData();
            FomDataGridView.Instancia.Show();
            Instancia.Hide();
        }
        #endregion


    }
}
