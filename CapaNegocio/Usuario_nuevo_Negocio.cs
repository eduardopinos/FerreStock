using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using Microsoft.Data.SqlClient;
using CapaEntidades;


namespace CapaNegocio
{
    public class Usuario_nuevo_Negocio
    {
        public void AgregarUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.documento <= 0 || string.IsNullOrWhiteSpace(usuario.apellido) || string.IsNullOrWhiteSpace(usuario.nombre) || string.IsNullOrWhiteSpace(usuario.usuario) || string.IsNullOrWhiteSpace(usuario.contraseña) || string.IsNullOrWhiteSpace(usuario.correo))
                {
                    throw new Exception("hay campos que son obligatorios");

                }
                else 
                {
                    UsuarioNuevoDatos datos = new UsuarioNuevoDatos();
                    datos.AgregarUsuario(usuario);
                }

            }
            catch (Exception ex)
            {

                throw ;
            }
        }
    }
}
