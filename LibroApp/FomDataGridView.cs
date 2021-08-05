﻿using BusinesLayer;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
//using System.Configuration.Install;
namespace LibroApp
{
    public partial class FomDataGridView : Form
    {
        #region Instancia
        public static FomDataGridView Instancia { get; } = new FomDataGridView();
        #endregion

        private BibliotecaService service;

        public FomDataGridView()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            service = new BibliotecaService(connection);
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
            DgvData.DataSource = service.GetAll();

            DgvData.ClearSelection();
        }

        public void Deselect()
        {
            DgvData.ClearSelection();
            BtnDeselect.Visible = false;
            //id = null;
        }
        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
