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
using CapaEntidades;
using System.Reflection.Metadata.Ecma335;

namespace FerreteriaStock
{
    public partial class frmStock : System.Windows.Forms.Form
    {
        private List<Producto> ListarProductos;
        public frmStock()
        {
            InitializeComponent();
            lbluUsuarioActual.Text = $"Usuario: {SesionActual.Usuario}";
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
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.ShowDialog();
            cargar();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargar()
        {
            Listado_de_productos conectar = new Listado_de_productos();
            ListarProductos = conectar.listar();
            dGVStock.DataSource = ListarProductos;

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            try
            {
                if (string.IsNullOrEmpty(busqueda))
                {
                    dGVStock.DataSource = ListarProductos;
                }
                else
                {
                    var productosFiltrados = ListarProductos.FindAll(p =>
                        p.producto.ToLower().Contains(busqueda) ||
                        p.categoria.ToLower().Contains(busqueda)
                    );
                    dGVStock.DataSource = productosFiltrados;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
