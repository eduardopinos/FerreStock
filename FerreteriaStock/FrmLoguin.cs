using CapaNegocio;
using System.Security.Cryptography.X509Certificates;
using CapaEntidades;

namespace FerreteriaStock
{
    public partial class FrmLoguin : System.Windows.Forms.Form
    {
        public FrmLoguin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarse ventana = new FrmRegistrarse();
            ventana.ShowDialog();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.usuario = txtUsuario.Text;
                usuario.contraseña = txtContraseña.Text;
                ChequearUsuarioContraseñaNegocio chequear = new ChequearUsuarioContraseñaNegocio();
                if (chequear.ValidarUsuarioContraseña(usuario))
                {
                    frmStock Ventana = new frmStock();

                    Ventana.ShowDialog();
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, verifica tus credenciales e intenta nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    txtUsuario.Clear();
                }








            }
            catch (Exception)
            {
              
                
                throw;
            }
            
        }
    }
}
