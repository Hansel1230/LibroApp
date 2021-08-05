using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using System.Data.SqlClient;
using BusinesLayer;

namespace LibroApp
{
    public sealed partial class FomPantallaPrincipal : Form
    {
        #region Instancia
        public static FomPantallaPrincipal Instancia {get;}=new FomPantallaPrincipal();
        #endregion

        public string TipoMantenimiento { get; set; }

        bool isvalid = true;

        //private BibliotecaService service; 

        private FomPantallaPrincipal()
        {
            InitializeComponent();

            //SqlConnection  connection= new SqlConnection();

           // service = new BibliotecaService(connection);
            
        }

        #region Eventos
        private void BtnAutores_Click(object sender, EventArgs e)
        {
            TipoMantenimiento = "Autores";
            FomDataGridView.Instancia.Show();
            Instancia.Hide();
        }
        private void BtnEditoriales_Click(object sender, EventArgs e)
        {
            TipoMantenimiento = "Editoriales";
            Instancia.Hide();
            FomDataGridView.Instancia.Show();
            
        }
        private void BtnLibros_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (FomMantLibros.Instancia.Autores.Count <=0)
            {
                MessageBox.Show("Debe Ingresar Autores");
                isvalid = false;
            }
            else if (FomMantLibros.Instancia.Editoriales.Count <=0)
            {
                MessageBox.Show("Debe Ingresar Editoriales");
                isvalid = false;
            }
            if (isvalid)
            {
                TipoMantenimiento = "Libros";
                FomDataGridView.Instancia.Show();
                Instancia.Hide();
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

        #endregion

        
    }
}
