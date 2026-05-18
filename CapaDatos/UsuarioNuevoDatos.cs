using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using CapaEntidades;


namespace CapaDatos
{
    public class UsuarioNuevoDatos
    {
        public void AgregarUsuario(Usuario Usuario)
        {
            acceso_a_datos acceso = new acceso_a_datos();
            try
            {
               if (acceso.ExisteUsuario(Usuario.usuario))
                {
                    throw new Exception("El nombre de usuario ya existe. Por favor, elija otro.");
                }

                else
                {
                    acceso.setear_datos("INSERT INTO Usuarios (documento, nombre, apellido, correo, usuario, contraseña) VALUES (@documento, @nombre, @apellido, @correo, @usuario, @contraseña)");
                    acceso.setear_parametros("@documento", Usuario.documento);
                    acceso.setear_parametros("@nombre", Usuario.nombre);
                    acceso.setear_parametros("@apellido", Usuario.apellido);
                    acceso.setear_parametros("@correo", Usuario.correo);
                    acceso.setear_parametros("@usuario", Usuario.usuario);
                    acceso.setear_parametros("@contraseña", Usuario.contraseña);
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
    }
}
