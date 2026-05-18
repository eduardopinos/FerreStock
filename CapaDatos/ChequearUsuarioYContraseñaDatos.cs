using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class ChequearUsuarioYContraseñaDatos
    {
        public bool ValidarUsuarioContraseña(string usuario, string contraseña)
        {
            acceso_a_datos acceso = new acceso_a_datos();


            try
            {
                acceso.setear_datos("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña");
                acceso.setear_parametros("@Usuario", usuario);
                acceso.setear_parametros("@Contraseña", contraseña);
                acceso.ejecutar_lectura();
                if (acceso.Lector.Read())
                {
                    int count = acceso.Lector.GetInt32(0);
                    if (count > 0)
                    {
                        return count > 0;
                    }


                }
                
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario y la contraseña.", ex);
            }
            finally
            {
                acceso.cerrar_conexion();

            }
        }
    }
}