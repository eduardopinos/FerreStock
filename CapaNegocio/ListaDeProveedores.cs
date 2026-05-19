using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaNegocio
{
    public class ListaDeProveedores
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            acceso_a_datos acceso = new acceso_a_datos();
            try
            {
                acceso.setear_datos("select id, nombre, correo, telefono, direccion, cuit, categoria, web, catalogo from dbo.Proveedores;");
                acceso.ejecutar_lectura();
                while (acceso.Lector.Read())
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor.id = Convert.ToInt32(acceso.Lector["id"]);
                    proveedor.nombre = (string)acceso.Lector["nombre"];
                    proveedor.correo = (string)acceso.Lector["correo"];
                    proveedor.telefono = Convert.ToInt32(acceso.Lector["telefono"]);
                    proveedor.direccion = (string)acceso.Lector["direccion"];
                    proveedor.cuit = (string)acceso.Lector["cuit"];
                    proveedor.categoria = (string)acceso.Lector["categoria"];
                    proveedor.web = (string)acceso.Lector["web"];
                    proveedor.catalogo = acceso.Lector["catalogo"] != DBNull.Value ? (string)acceso.Lector["catalogo"].ToString():"";

                    lista.Add(proveedor);
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
