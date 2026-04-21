namespace FerreteriaStock
{
    partial class FrmRegistrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpNuevoRegistro = new GroupBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            mskDocumento = new MaskedTextBox();
            lblDocumento = new Label();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            mskTelefonoFijo = new MaskedTextBox();
            lblTelefonoFijo = new Label();
            mskCorreo = new MaskedTextBox();
            lblCorreo = new Label();
            txtDireccion = new TextBox();
            mskTelefono = new MaskedTextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblTelefonoCelular = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            lblNuevoUsuario = new Label();
            dtmRegistrarse = new DateTimePicker();
            grpNuevoRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // grpNuevoRegistro
            // 
            grpNuevoRegistro.Controls.Add(txtContraseña);
            grpNuevoRegistro.Controls.Add(txtUsuario);
            grpNuevoRegistro.Controls.Add(lblContraseña);
            grpNuevoRegistro.Controls.Add(lblUsuario);
            grpNuevoRegistro.Controls.Add(mskDocumento);
            grpNuevoRegistro.Controls.Add(lblDocumento);
            grpNuevoRegistro.Controls.Add(btnLimpiar);
            grpNuevoRegistro.Controls.Add(btnCancelar);
            grpNuevoRegistro.Controls.Add(btnAceptar);
            grpNuevoRegistro.Controls.Add(mskTelefonoFijo);
            grpNuevoRegistro.Controls.Add(lblTelefonoFijo);
            grpNuevoRegistro.Controls.Add(mskCorreo);
            grpNuevoRegistro.Controls.Add(lblCorreo);
            grpNuevoRegistro.Controls.Add(txtDireccion);
            grpNuevoRegistro.Controls.Add(mskTelefono);
            grpNuevoRegistro.Controls.Add(txtApellido);
            grpNuevoRegistro.Controls.Add(txtNombre);
            grpNuevoRegistro.Controls.Add(lblApellido);
            grpNuevoRegistro.Controls.Add(lblTelefonoCelular);
            grpNuevoRegistro.Controls.Add(lblDireccion);
            grpNuevoRegistro.Controls.Add(lblNombre);
            grpNuevoRegistro.Location = new Point(12, 25);
            grpNuevoRegistro.Name = "grpNuevoRegistro";
            grpNuevoRegistro.Size = new Size(776, 272);
            grpNuevoRegistro.TabIndex = 0;
            grpNuevoRegistro.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(558, 66);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = 'x';
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 22;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(558, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 21;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(452, 73);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 20;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(459, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 19;
            lblUsuario.Text = "Usuario";
            // 
            // mskDocumento
            // 
            mskDocumento.Location = new Point(558, 108);
            mskDocumento.Mask = "99999999";
            mskDocumento.Name = "mskDocumento";
            mskDocumento.Size = new Size(100, 23);
            mskDocumento.TabIndex = 18;
            mskDocumento.ValidatingType = typeof(int);
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(452, 111);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(69, 15);
            lblDocumento.TabIndex = 17;
            lblDocumento.Text = "documento";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(398, 228);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(220, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(58, 228);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // mskTelefonoFijo
            // 
            mskTelefonoFijo.Location = new Point(311, 128);
            mskTelefonoFijo.Mask = "(999)000-0000";
            mskTelefonoFijo.Name = "mskTelefonoFijo";
            mskTelefonoFijo.Size = new Size(100, 23);
            mskTelefonoFijo.TabIndex = 13;
            // 
            // lblTelefonoFijo
            // 
            lblTelefonoFijo.AutoSize = true;
            lblTelefonoFijo.Location = new Point(233, 136);
            lblTelefonoFijo.Name = "lblTelefonoFijo";
            lblTelefonoFijo.Size = new Size(72, 15);
            lblTelefonoFijo.TabIndex = 12;
            lblTelefonoFijo.Text = "Telefono fijo";
            // 
            // mskCorreo
            // 
            mskCorreo.Location = new Point(311, 82);
            mskCorreo.Name = "mskCorreo";
            mskCorreo.Size = new Size(100, 23);
            mskCorreo.TabIndex = 11;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(239, 85);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(113, 77);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 9;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(113, 131);
            mskTelefono.Mask = "000-000-0000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(100, 23);
            mskTelefono.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(311, 30);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(239, 38);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblTelefonoCelular
            // 
            lblTelefonoCelular.AutoSize = true;
            lblTelefonoCelular.Location = new Point(6, 131);
            lblTelefonoCelular.Name = "lblTelefonoCelular";
            lblTelefonoCelular.Size = new Size(92, 15);
            lblTelefonoCelular.TabIndex = 2;
            lblTelefonoCelular.Text = "Telefono Celular";
            lblTelefonoCelular.Click += lblTelefonoCelular_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 74);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(51, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direcion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblNuevoUsuario
            // 
            lblNuevoUsuario.AutoSize = true;
            lblNuevoUsuario.Location = new Point(69, 4);
            lblNuevoUsuario.Name = "lblNuevoUsuario";
            lblNuevoUsuario.Size = new Size(82, 15);
            lblNuevoUsuario.TabIndex = 1;
            lblNuevoUsuario.Text = "nuevo usuario";
            // 
            // dtmRegistrarse
            // 
            dtmRegistrarse.Location = new Point(440, 303);
            dtmRegistrarse.Name = "dtmRegistrarse";
            dtmRegistrarse.Size = new Size(230, 23);
            dtmRegistrarse.TabIndex = 2;
            // 
            // FrmRegistrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtmRegistrarse);
            Controls.Add(lblNuevoUsuario);
            Controls.Add(grpNuevoRegistro);
            Name = "FrmRegistrarse";
            Text = "Registrarse";
            grpNuevoRegistro.ResumeLayout(false);
            grpNuevoRegistro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpNuevoRegistro;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblTelefonoCelular;
        private Label lblDireccion;
        private Label lblNombre;
        private TextBox txtApellido;
        private MaskedTextBox mskTelefono;
        private TextBox txtDireccion;
        private MaskedTextBox mskCorreo;
        private Label lblCorreo;
        private MaskedTextBox mskTelefonoFijo;
        private Label lblTelefonoFijo;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnAceptar;
        private MaskedTextBox mskDocumento;
        private Label lblDocumento;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblUsuario;
        private Label lblNuevoUsuario;
        private DateTimePicker dtmRegistrarse;
    }
}