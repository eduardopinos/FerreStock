using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using CapaDatos;

namespace CapaVista
{
    public partial class FrmNuevoProducto : Form
    {
        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                Producto producto = new Producto();
                producto.producto = txtProducto.Text;
                producto.categoria = txtCategoria.Text;
                producto.proveedor = txtProveedor.Text;
                producto.cantidad = int.Parse(txtCantidad.Text);
                producto.precio_de_compra = decimal.Parse(txtPrecioCompra.Text);
                producto.precio_de_venta = decimal.Parse(txtPrecioVenta.Text);
                producto.imagen = lnkImagen.Text;

                AgregarProductoNegocio negocio = new AgregarProductoNegocio();
                negocio.AgregarProducto(producto);

                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                txtProducto.Clear();
                txtCategoria.Clear();
                txtProveedor.Clear();
                txtCantidad.Clear();
                txtPrecioCompra.Clear();
                txtPrecioVenta.Clear();
                lnkImagen.Text = "";





            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}