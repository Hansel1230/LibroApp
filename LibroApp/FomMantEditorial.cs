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
    public partial class FomMantEditorial : Form
    {
        #region Instancia
        public static FomMantEditorial Instancia { get; } = new FomMantEditorial();
        #endregion

        bool isvalid;

        public FomMantEditorial()
        {
            InitializeComponent();
        }

        #region Eventos

        private void FomMantEditorial_Load(object sender, EventArgs e)
        {
            FullTxt();
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
                FomMantLibros.Instancia.Editoriales.Add(TxtNombre.Text);
                FomDataGridView.Instancia.LoadData();
                FomDataGridView.Instancia.Show();
                Instancia.Hide();
                FullTxt();               
            }
            
        }
        //Mantenimiento TxtNombre.Text
        private void TxtNombre_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text== "Ingrese Nombre:")
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
            if (TxtTelefono.Text== "Ingrese Telefono:")
            {
                TxtTelefono.Text = "";
            }
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Text== "")
            {
                TxtTelefono.Text = "Ingrese Telefono:";
            }
        }

        //Mantenimiento TxtPais.Text
        private void TxtPais_Click(object sender, EventArgs e)
        {
            if (TxtPais.Text== "Ingrese Nombre del Pais:")
            {
                TxtPais.Text ="";
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
        #endregion

        
    }

}
