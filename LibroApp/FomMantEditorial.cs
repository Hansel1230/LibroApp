using BusinesLayer;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibroApp
{
    public partial class FomMantEditorial : Form
    {
        #region Instancia
        public static FomMantEditorial Instancia { get; } = new FomMantEditorial();
        #endregion

        #region variables
        private int EditorId { get; set; } = 0;
        private BibliotecaService service;
        private bool isvalid;
        #endregion


        public FomMantEditorial()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);

            service = new BibliotecaService(connection);
        }

        #region Eventos

        private void FomMantEditorial_Load(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FomDataGridView.Instancia.Show();
            Instancia.Hide();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (TxtNombre.Text == "Ingrese Nombre:")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                isvalid = false;
            }
            else if (TxtTelefono.Text == "Ingrese Telefono:")
            {
                MessageBox.Show("Debe ingresar un Telefono");
                isvalid = false;
            }
            else if (TxtPais.Text == "Ingrese Nombre del Pais:")
            {
                MessageBox.Show("Debe ingresar un Pais");
                isvalid = false;
            }
            if (isvalid)
            {
                Database.Modelos.Editorial editorial = new Database.Modelos.Editorial(TxtNombre.Text, TxtPais.Text, TxtTelefono.Text);

                if (EditorId > 0)
                {
                    service.EditarEditorial(editorial, EditorId);
                    EditorId = 0;
                }
                else
                {
                    service.AgregarEditorial(editorial);
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

        //Mantenimiento TxtTelefono.Text
        private void TxtTelefono_Click(object sender, EventArgs e)
        {
            if (TxtTelefono.Text == "Ingrese Telefono:")
            {
                TxtTelefono.Text = "";
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Text == "")
            {
                TxtTelefono.Text = "Ingrese Telefono:";
            }
        }

        //Mantenimiento TxtPais.Text
        private void TxtPais_Click(object sender, EventArgs e)
        {
            if (TxtPais.Text == "Ingrese Nombre del Pais:")
            {
                TxtPais.Text = "";
            }
        }

        private void TxtPais_Leave(object sender, EventArgs e)
        {
            if (TxtPais.Text == "")
            {
                TxtPais.Text = "Ingrese Nombre del Pais:";
            }
        }

        private void FomMantEditorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Metodos

        public void FullTxt()
        {
            TxtNombre.Text = "Ingrese Nombre:";
            TxtPais.Text = "Ingrese Nombre del Pais:";
            TxtTelefono.Text = "Ingrese Telefono:";
        }
        public void LoadTxt()
        {
            if (FomDataGridView.Instancia.FilaSeleccionada != null)
            {
                EditorId = Convert.ToInt16(FomDataGridView.Instancia.FilaSeleccionada.Cells[0].Value);
                TxtNombre.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[1].Value.ToString();
                TxtTelefono.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[2].Value.ToString();
                TxtPais.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[3].Value.ToString();
                FomDataGridView.Instancia.FilaSeleccionada = null;
            }
        }

        #endregion
    }

}
