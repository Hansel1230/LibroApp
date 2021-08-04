using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroApp
{
    public partial class FomDataGridView : Form
    {
        #region Instancia
        public static FomDataGridView Instancia { get; } = new FomDataGridView();
        #endregion

        public FomDataGridView()
        {
            InitializeComponent();
        }
        #region Eventos
        private void FomDataGridView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Autores")
            {
                FomMantAutores.Instancia.Show();
                Instancia.Hide();
            }
            else if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Libros")
            {
                FomMantLibros.Instancia.Show();
                Instancia.Hide();
            }
            else
            {
                FomMantEditorial.Instancia.Show();
                Instancia.Hide();
            }            
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Autores")
            {
                FomMantAutores.Instancia.Show();
                Instancia.Hide();
            }
            else if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Libros")
            {
                FomMantLibros.Instancia.Show();
                Instancia.Hide();
            }
            else
            {
                FomMantEditorial.Instancia.Show();
                Instancia.Hide();
            }
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
        #endregion

        #region Metodos

        public void LoadData()
        {
            if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Autores")
            {               
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = FomMantLibros.Instancia.Autores;

                DgvData.DataSource = bindingSource;
            }
            else if (FomPantallaPrincipal.Instancia.TipoMantenimiento == "Libros")
            {
                FomMantLibros.Instancia.Show();
                Instancia.Hide();
            }
            else
            {
                FomMantEditorial.Instancia.Show();
                Instancia.Hide();
            }
       
        }

        #endregion
    }
}
