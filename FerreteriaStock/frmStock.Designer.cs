namespace FerreteriaStock
{
    partial class frmStock
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            dGVStock = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnConfigurar = new Button();
            btnProveedores = new Button();
            btnNuevoProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVStock).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(130, 391);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 37);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(258, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 37);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(557, 425);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(231, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dGVStock
            // 
            dGVStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVStock.Location = new Point(26, 48);
            dGVStock.Name = "dGVStock";
            dGVStock.Size = new Size(730, 325);
            dGVStock.TabIndex = 3;
            dGVStock.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(35, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(160, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 5;
            // 
            // btnConfigurar
            // 
            btnConfigurar.Location = new Point(392, 391);
            btnConfigurar.Name = "btnConfigurar";
            btnConfigurar.Size = new Size(83, 37);
            btnConfigurar.TabIndex = 6;
            btnConfigurar.Text = "Configurar";
            btnConfigurar.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(557, 10);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(92, 38);
            btnProveedores.TabIndex = 7;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(316, 10);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(112, 37);
            btnNuevoProducto.TabIndex = 8;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoProducto);
            Controls.Add(btnProveedores);
            Controls.Add(btnConfigurar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dGVStock);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "frmStock";
            Text = "Stock";
            Load += frmStock_Load;
            ((System.ComponentModel.ISupportInitialize)dGVStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private DateTimePicker dateTimePicker1;
        private DataGridView dGVStock;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnConfigurar;
        private Button btnProveedores;
        private Button btnNuevoProducto;
    }
}