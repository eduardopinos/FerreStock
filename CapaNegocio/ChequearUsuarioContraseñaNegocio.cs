using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ChequearUsuarioContraseñaNegocio
    {
        public bool ValidarUsuarioContraseña( Usuario usuario)
        {
           
            try
            {
                if (string.IsNullOrWhiteSpace(usuario.usuario) || string.IsNullOrWhiteSpace(usuario.contraseña))
                {
                    return false;

                }
                else
                {
                    ChequearUsuarioYContraseñaDatos acceso = new ChequearUsuarioYContraseñaDatos();
                    return acceso.ValidarUsuarioContraseña(usuario.usuario, usuario.contraseña);
                }
               
            }
            catch (Exception )
            {

                throw;
            }
        
               

        }
        
    
    }
}
