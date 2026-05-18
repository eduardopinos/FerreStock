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
            FrmProveedores Ventana = new FrmProveedores();
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
            Listado_de_productos conectar = new CapaNegocio.Listado_de_productos();
            dGVStock.DataSource = conectar.listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
