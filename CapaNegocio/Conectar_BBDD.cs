using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;


namespace CapaNegocio
{
    public class Conectar_BBDD
    {
         public  List<Producto> listar()
        {

            List<Producto> lista = new List<Producto>();

            SqlConnection connexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                connexion.ConnectionString = "server=.\\SQLEXPRESS; database =FerreStock;integrated security = true; TrustServerCertificate=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id_producto, producto, categoria,proveedor, cantidad, precio_compra, precio_venta, imagen from dbo.Inventario;";
                comando.Connection = connexion;
                connexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(lector["id_producto"]);
                    producto.producto = lector.GetString(1);
                    producto.categoria = lector.GetString(2);
                    producto.proveedor = lector.GetString(3);
                    producto.cantidad = Convert.ToInt32(lector["cantidad"]);
                    producto.precio_de_compra = lector.GetDecimal(5);
                    producto.precio_de_venta = lector.GetDecimal(6);
                    producto.imagen = !lector.IsDBNull(7)? lector.GetString(7):"";
                    lista.Add(producto);
                }
                connexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ;
            }
           
            
             
            
        }
    }
}
