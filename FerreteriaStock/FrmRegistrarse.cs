using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;

namespace FerreteriaStock
{
    public partial class FrmRegistrarse : Form
    {
        public FrmRegistrarse()
        {
            InitializeComponent();
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            mskCorreo.Clear();
            mskDocumento.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

            try
            {
                Usuario Usuario = new Usuario();

                Usuario.nombre = txtNombre.Text;
                Usuario.apellido = txtApellido.Text;
                Usuario.usuario = txtUsuario.Text;
                Usuario.contraseña = txtContraseña.Text;
                Usuario.documento = int.Parse(mskDocumento.Text);
                Usuario.correo = mskCorreo.Text;
                
                Usuario_nuevo_Negocio negocio = new Usuario_nuevo_Negocio();
                negocio.AgregarUsuario(Usuario);
                MessageBox.Show("Usuario registrado con exito", "exito", MessageBoxButtons.OK , MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApellido.Clear();
                txtUsuario.Clear();
                txtContraseña.Clear();
                mskDocumento.Clear();
                mskCorreo.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
