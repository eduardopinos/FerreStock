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
            mskCorreo = new MaskedTextBox();
            lblCorreo = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblNuevoUsuario = new Label();
            dtmRegistrarse = new DateTimePicker();
            grpNuevoRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // grpNuevoRegistro
            // 
            grpNuevoRegistro.BackColor = Color.LightCyan;
            grpNuevoRegistro.Controls.Add(txtContraseña);
            grpNuevoRegistro.Controls.Add(txtUsuario);
            grpNuevoRegistro.Controls.Add(lblContraseña);
            grpNuevoRegistro.Controls.Add(lblUsuario);
            grpNuevoRegistro.Controls.Add(mskDocumento);
            grpNuevoRegistro.Controls.Add(lblDocumento);
            grpNuevoRegistro.Controls.Add(btnLimpiar);
            grpNuevoRegistro.Controls.Add(btnCancelar);
            grpNuevoRegistro.Controls.Add(btnAceptar);
            grpNuevoRegistro.Controls.Add(mskCorreo);
            grpNuevoRegistro.Controls.Add(lblCorreo);
            grpNuevoRegistro.Controls.Add(txtApellido);
            grpNuevoRegistro.Controls.Add(txtNombre);
            grpNuevoRegistro.Controls.Add(lblApellido);
            grpNuevoRegistro.Controls.Add(lblNombre);
            grpNuevoRegistro.Location = new Point(12, 25);
            grpNuevoRegistro.Name = "grpNuevoRegistro";
            grpNuevoRegistro.Size = new Size(776, 272);
            grpNuevoRegistro.TabIndex = 0;
            grpNuevoRegistro.TabStop = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(558, 74);
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
            lblContraseña.Location = new Point(449, 85);
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
            mskDocumento.Location = new Point(311, 77);
            mskDocumento.Mask = "99999999";
            mskDocumento.Name = "mskDocumento";
            mskDocumento.Size = new Size(100, 23);
            mskDocumento.TabIndex = 18;
            mskDocumento.ValidatingType = typeof(int);
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(239, 85);
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
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(58, 228);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // mskCorreo
            // 
            mskCorreo.Location = new Point(113, 82);
            mskCorreo.Name = "mskCorreo";
            mskCorreo.Size = new Size(100, 23);
            mskCorreo.TabIndex = 11;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(23, 82);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo";
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
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(dtmRegistrarse);
            Controls.Add(lblNuevoUsuario);
            Controls.Add(grpNuevoRegistro);
            Name = "FrmRegistrarse";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblNombre;
        private TextBox txtApellido;
        private MaskedTextBox mskCorreo;
        private Label lblCorreo;
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