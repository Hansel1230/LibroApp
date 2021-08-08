using BusinesLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibroApp
{
    public partial class FomDataGridView : Form
    {
        #region Instancia
        public static FomDataGridView Instancia { get; } = new FomDataGridView();
        #endregion

        public DataGridViewRow FilaSeleccionada = null;
        private int index = 0;
        private BibliotecaService service;

        public FomDataGridView()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            service = new BibliotecaService(connection);
        }

        #region Eventos
        private void FomDataGridView_Load(object sender, EventArgs e)
        {
            Deselect();
        }
        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FomPantallaPrincipal.Instancia.Show();
            Instancia.Hide();
        }

        private void FomDataGridView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FilaSeleccionada = DgvData.Rows[e.RowIndex];
                BtnEliminar.Visible = true;
                BtnDeselect.Visible = true;
                BtnListar.Visible = true;
                BtnEditar.Visible = true;
            }

        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Autores")
            {
                FomMantAutores.Instancia.FullTxt();
                FomMantAutores.Instancia.Show();
                Instancia.Hide();
            }
            else if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Libros")
            {
                FomMantLibros.Instancia.FullTxt();
                FomMantLibros.Instancia.Show();
                Instancia.Hide();
            }
            else
            {
                FomMantEditorial.Instancia.FullTxt();
                FomMantEditorial.Instancia.Show();
                Instancia.Hide();
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Autores")
            {
                FomMantAutores.Instancia.LoadTxt();
                FomMantAutores.Instancia.Show();
                
            }
            else if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Libros")
            {
                FomMantLibros.Instancia.LoadTxt();
                FomMantLibros.Instancia.Show();
                
            }
            else
            {
                FomMantEditorial.Instancia.LoadTxt();
                FomMantEditorial.Instancia.Show();
                
            }
            Instancia.Hide();
            Deselect();
        }
       

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Autores")
            {
                // eliminar autores
                service.EliminarAutor(Convert.ToInt16(FilaSeleccionada.Cells[0].Value));
                
            }
            else if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Libros")
            {
                // eliminar libros
                service.EliminarLibro(Convert.ToInt16(FilaSeleccionada.Cells[0].Value));
                
            }
            else
            {
                // eliminar editorial
                service.EliminarEditorial(Convert.ToInt16(FilaSeleccionada.Cells[0].Value));
                
            }
            Deselect(); 
            LoadData();
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        #endregion

        #region Metodos

        public void LoadData()
        {
            if (FomPantallaPrincipal.Instancia.TipoMantenimiento== "Autores")
            {
                DgvData.DataSource = service.GetAllAutor();
            }
            else if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Editoriales")
            {
                DgvData.DataSource = service.GetallEditoriales();
            }
            else
            {
                DgvData.DataSource = service.GetAllLibros();
            }
                DgvData.ClearSelection();
        }

        public void Deselect()
        {
            DgvData.ClearSelection();
            BtnDeselect.Visible = false;
            BtnEditar.Visible = false;
            BtnEliminar.Visible = false;
            BtnListar.Visible = false;
        }
        #endregion

    }
}
