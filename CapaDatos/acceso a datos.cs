using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class acceso_a_datos
    {
        private SqlConnection conexion;
        private SqlDataReader lector;
        private SqlCommand comando;
        public acceso_a_datos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database =FerreStock;integrated security = true; TrustServerCertificate=true");
            comando = new SqlCommand();
        }

        public void setear_datos(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        public void setear_parametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutar_lectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public SqlDataReader Lector { get { return lector; } }
        public void cerrar_conexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
        public void ejecutar_accion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool ExisteUsuario(string usuario)
        {
            acceso_a_datos datos = new acceso_a_datos();

            try
            {
                datos.setear_datos("SELECT COUNT(*) FROM Usuarios WHERE usuario = @usuario");
                datos.setear_parametros("@usuario", usuario);
                datos.ejecutar_lectura();
                if (datos.Lector.Read())
                {
                    int count = datos.Lector.GetInt32(0);
                    return count > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.cerrar_conexion();
            }
        }
        public bool ExisteUsuarioYContraseña(string usuario, string contraseña)
        {
            acceso_a_datos datos = new acceso_a_datos();

            try
            {
                datos.setear_datos("SELECT COUNT(*) FROM Usuarios WHERE usuario = @usuario, constraseña = @contraseña");
                datos.setear_parametros("@usuario", usuario);
                datos.setear_parametros("@contraseña", contraseña);
                datos.ejecutar_lectura();
                if (datos.Lector.Read())
                {
                    int count = datos.Lector.GetInt32(0);
                    return count > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                datos.cerrar_conexion();
            }
        }

    }
}
