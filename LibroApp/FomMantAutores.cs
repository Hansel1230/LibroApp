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
    public partial class FomMantAutores : Form
    {
        #region Instancia
        public static FomMantAutores Instancia { get; } = new FomMantAutores();
        #endregion

        bool isvalid;

        public FomMantAutores()
        {
            InitializeComponent();
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
                string FullName = TxtNombre.Text + " " + TxtApellido.Text;
                FomMantLibros.Instancia.Autores.Add(FullName);
                //FomMantLibros.Instancia.NombreCbx = TxtNombre.Text;
                FomDataGridView.Instancia.LoadData();
                FomDataGridView.Instancia.Show();
                Instancia.Hide();
                FullTxt();

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
        #endregion

        
    }
}
