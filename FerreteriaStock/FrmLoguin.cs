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
            frmStock Ventana = new frmStock();
            Ventana.ShowDialog();
        }
    }
}
