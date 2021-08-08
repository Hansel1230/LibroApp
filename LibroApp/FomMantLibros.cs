using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinesLayer.CustomControlItem;
using System.Data;

namespace LibroApp
{
    public partial class FomMantLibros : Form
    {
        public List<string> Editoriales { get; set; } = new List<string>();

        public List<string> Autores { get; set; } = new List<string>();

        public string NombreCbx { get; set; }

        #region instancia
        public static FomMantLibros Instancia { get; } = new FomMantLibros();
        #endregion
        private int LibroId { get; set; } = 0;
        bool isvalid;

        public FomMantLibros()
        {
            InitializeComponent();
        }

        #region Eventos
        private void FomMantLibros_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            isvalid = true;
            if (TxtNombre.Text == "Ingrese Nombre:")
            {
                MessageBox.Show("Debe ingresar un Nombre");
                isvalid = false;
            }
            else if (TxtFecha.Text == "Ingrese Fecha de publicacion:")
            {
                MessageBox.Show("Debe ingresar una fecha de publicacion");
                isvalid = false;
            }
            else if (CbxAutor.Text == "Seleccione una Opcion") 
            {
                MessageBox.Show("Debe Seleccionar un autor");
                isvalid = false;                
            }               
            else if (CbxEditorial.Text == "Seleccione una Opcion")
            {
                MessageBox.Show("Debe Seleccionar un Editorial"); isvalid = false;
            }
            if (isvalid)
            {
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
            if (TxtNombre.Text=="")
            {
                TxtNombre.Text = "Ingrese Nombre:";
            }
        }

        //Mantenimiento TxtFecha.Text
        private void TxtFecha_Click(object sender, EventArgs e)
        {
            if (TxtFecha.Text== "Ingrese Fecha de publicacion:")
            {
                TxtFecha.Text = "";
            }
        }

        private void TxtFecha_Leave(object sender, EventArgs e)
        {
            if (TxtFecha.Text=="")
            {
                TxtFecha.Text = "Ingrese Fecha de publicacion:";
            }
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FomDataGridView.Instancia.Show();
            Instancia.Hide();
        }

        private void FomMantLibros_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Metodos

        public void FullTxt()
        {
            TxtNombre.Text = "Ingrese Nombre:";
            TxtFecha.Text = "Ingrese Fecha de publicacion:";
            CbxAutor.Text = "Seleccione una Opcion";
            CbxEditorial.Text = "Seleccione una Opcion";
        }
        public void LoadTxt()
        {
            if (FomDataGridView.Instancia.FilaSeleccionada != null)
            {
                LibroId = Convert.ToInt16(FomDataGridView.Instancia.FilaSeleccionada.Cells[0].Value);
                TxtNombre.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[1].Value.ToString();
                TxtFecha.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[2].Value.ToString();
                CbxAutor.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[3].Value.ToString();
                CbxEditorial.Text = FomDataGridView.Instancia.FilaSeleccionada.Cells[4].Value.ToString();

                FomDataGridView.Instancia.FilaSeleccionada = null;
            }
        }
        #endregion

        #region ComboBox

        //Llenar ComboBox

        private void LoadComboBox()
        {
            int count = 0;

            //Opcion por Defecto
            ComboBoxItem OpcionDefecto = new ComboBoxItem();
            OpcionDefecto.Text = "Seleccione una Opcion";
            OpcionDefecto.Value = null;

            CbxAutor.Items.Add(OpcionDefecto);
            CbxAutor.SelectedItem = OpcionDefecto;

            CbxEditorial.Items.Add(OpcionDefecto);
            CbxEditorial.SelectedItem = OpcionDefecto;

            //Autores
            foreach (string autor in Autores)
            {
                count++;
                ComboBoxItem opcionAutor = new ComboBoxItem();
                opcionAutor.Text = autor;
                opcionAutor.Value = count;

                CbxAutor.Items.Add(opcionAutor);
            }
            //Editorial
            foreach (string editorial in Editoriales)
            {
                count++;
                ComboBoxItem opcioneditorial = new ComboBoxItem();
                opcioneditorial.Text = editorial;
                opcioneditorial.Value = count;

                CbxEditorial.Items.Add(opcioneditorial);
            }
        }
        
        #endregion
    }
}
