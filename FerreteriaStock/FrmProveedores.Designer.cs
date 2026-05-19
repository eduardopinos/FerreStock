namespace CapaVista
{
    partial class FrmProveedores
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
            dGVProveedores = new DataGridView();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            dtmProveedores = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dGVProveedores).BeginInit();
            SuspendLayout();
            // 
            // dGVProveedores
            // 
            dGVProveedores.BackgroundColor = SystemColors.ButtonHighlight;
            dGVProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVProveedores.Location = new Point(12, 104);
            dGVProveedores.Name = "dGVProveedores";
            dGVProveedores.Size = new Size(643, 293);
            dGVProveedores.TabIndex = 0;
            dGVProveedores.CellContentClick += dGVProveedores_CellContentClick;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(55, 44);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(133, 44);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(73, 421);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(237, 421);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // dtmProveedores
            // 
            dtmProveedores.Location = new Point(379, 423);
            dtmProveedores.Name = "dtmProveedores";
            dtmProveedores.Size = new Size(200, 23);
            dtmProveedores.TabIndex = 5;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(dtmProveedores);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(dGVProveedores);
            Name = "FrmProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dGVProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVProveedores;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Button btnEditar;
        private DateTimePicker dtmProveedores;
    }
}