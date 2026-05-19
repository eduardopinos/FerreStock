using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CrearNuevoProductoDatos
    {
        public void AgregarProducto(Producto producto)
        {
            acceso_a_datos acceso = new acceso_a_datos();
            try
            {
                if (ExisteProducto(producto.producto))
                {
                    throw new Exception("El producto ya existe. Por favor, elija otro.");
                }
                else
                {
                    acceso.setear_datos("INSERT INTO Inventario (producto, categoria, proveedor, cantidad, precio_compra, precio_venta, imagen) VALUES (@producto, @categoria, @proveedor, @cantidad, @precio_compra, @precio_venta, @imagen)");
                    acceso.setear_parametros("@producto", producto.producto);
                    acceso.setear_parametros("@categoria", producto.categoria);
                    acceso.setear_parametros("@proveedor", producto.proveedor);
                    acceso.setear_parametros("@cantidad", producto.cantidad);
                    acceso.setear_parametros("@precio_compra", producto.precio_de_compra);
                    acceso.setear_parametros("@precio_venta", producto.precio_de_venta);
                    acceso.setear_parametros("@imagen", producto.imagen);
                    acceso.ejecutar_accion();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                acceso.cerrar_conexion();
            }
        }
        bool ExisteProducto(string nombreProducto)
        {
            acceso_a_datos acceso = new acceso_a_datos();
            try
            {
                acceso.setear_datos("SELECT COUNT(*) FROM Inventario WHERE producto = @producto");
                acceso.setear_parametros("@producto", nombreProducto);
                acceso.ejecutar_lectura();
                if (acceso.Lector.Read()) 
                {
                    int count = acceso.Lector.GetInt32(0);
                    return count > 0;
                }
                return false;
                
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                acceso.cerrar_conexion();
            }

        }
    }
}
