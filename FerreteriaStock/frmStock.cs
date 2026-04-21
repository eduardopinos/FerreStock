using CapaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace FerreteriaStock
{
    public partial class frmStock : System.Windows.Forms.Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmNuevo_Proveedor Ventana = new frmNuevo_Proveedor();
            Ventana.ShowDialog();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto Ventana = new FrmNuevoProducto();
            Ventana.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            Conectar_BBDD conectar = new CapaNegocio.Conectar_BBDD();
            dGVStock.DataSource = conectar.listar();
        }
    }
}
