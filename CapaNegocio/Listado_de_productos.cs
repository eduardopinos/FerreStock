using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using Microsoft.Data.SqlClient;
using CapaEntidades;



namespace CapaNegocio
{
    public class Listado_de_productos
    {
        public List<Producto> listar()
        {

            List<Producto> lista = new List<Producto>();
            acceso_a_datos acceso = new acceso_a_datos();

            try
            {
                acceso.setear_datos("select  producto, categoria,proveedor, cantidad, precio_compra, precio_venta, imagen from dbo.Inventario;");
                acceso.ejecutar_lectura();

                while (acceso.Lector.Read())
                {
                    Producto producto = new Producto();

                    producto.producto = (string)acceso.Lector["producto"];
                    producto.categoria = (string)acceso.Lector["categoria"];
                    producto.proveedor = (string)acceso.Lector["proveedor"];
                    producto.cantidad = Convert.ToInt32(acceso.Lector["cantidad"]);
                    producto.precio_de_compra = (decimal)acceso.Lector["precio_compra"];
                    producto.precio_de_venta = (decimal)acceso.Lector["precio_venta"];
                    producto.imagen = Convert.ToString(acceso.Lector["imagen"]);
                    lista.Add(producto);
                }
                acceso.cerrar_conexion();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }




        }
        
    }
}
