using System;
using System.Windows.Forms;

namespace LibroApp
{
    public sealed partial class FomPantallaPrincipal : Form
    {
        #region Instancia
        public static FomPantallaPrincipal Instancia { get; } = new FomPantallaPrincipal();
        #endregion

        public string TipoMantenimiento { get; set; }

        bool isvalid = true;
        
        private FomPantallaPrincipal()
        {
            InitializeComponent();
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
            isvalid = true;
            if (FomMantLibros.Instancia.Autores.Count <= 0)
            {
                MessageBox.Show("Debe Ingresar Autores");
                isvalid = false;
            }
            else if (FomMantLibros.Instancia.Editoriales.Count <= 0)
            {
                MessageBox.Show("Debe Ingresar Editoriales");
                isvalid = false;
            }
            if (isvalid)
            {
                TipoMantenimiento = "Libros";
                moverADGV();
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
            FomDataGridView.Instancia.Show();
            Instancia.Hide();
        }
        #endregion


    }
}
