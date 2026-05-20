using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            lblsesionActual.Text = $"Usuario: {SesionActual.Usuario}";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevo_Proveedor Ventana = new frmNuevo_Proveedor();
            Ventana.ShowDialog();
        }

        private void dGVProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            ListaDeProveedores lista = new ListaDeProveedores();

            dGVProveedores.DataSource = lista.Listar();
        }
    }
}
