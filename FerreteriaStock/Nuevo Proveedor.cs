using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmNuevo_Proveedor : Form
    {
        public frmNuevo_Proveedor()
        {
            InitializeComponent();
            lblsesionActual.Text = $"Usuario: {SesionActual.Usuario}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
