using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class AgregarProductoNegocio
    {
        public void AgregarProducto(Producto producto)
        {
            if (producto.producto == null || producto.categoria == null || producto.proveedor == null)
            {
                throw new ArgumentException("El nombre del producto, la categoría y el proveedor no pueden ser nulos.");
            }
            if (producto.cantidad < 0)
            {
                throw new ArgumentException("La cantidad no puede ser negativa.");
            }
            if (producto.precio_de_compra < 0 || producto.precio_de_venta < 0)
            {
                throw new ArgumentException("Los precios no pueden ser negativos.");
            }
            CrearNuevoProductoDatos datos = new CrearNuevoProductoDatos();
            datos.AgregarProducto(producto);

        }
    }
}
