namespace Libreria
{
    partial class FrmVentas
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
            this.lbFolio = new System.Windows.Forms.Label();
            this.tbFolio = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.lbNoControl = new System.Windows.Forms.Label();
            this.tbNoControl = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.lbExistencia = new System.Windows.Forms.Label();
            this.tbExistencia = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.btnBuscarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFolio
            // 
            this.lbFolio.AutoSize = true;
            this.lbFolio.Location = new System.Drawing.Point(12, 9);
            this.lbFolio.Name = "lbFolio";
            this.lbFolio.Size = new System.Drawing.Size(32, 13);
            this.lbFolio.TabIndex = 0;
            this.lbFolio.Text = "Folio:";
            // 
            // tbFolio
            // 
            this.tbFolio.Location = new System.Drawing.Point(63, 6);
            this.tbFolio.MaxLength = 10;
            this.tbFolio.Name = "tbFolio";
            this.tbFolio.Size = new System.Drawing.Size(100, 20);
            this.tbFolio.TabIndex = 1;
            this.tbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFolio_KeyPress);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(12, 38);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(40, 13);
            this.lbFecha.TabIndex = 2;
            this.lbFecha.Text = "Fecha:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(63, 32);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 3;
            // 
            // lbNoControl
            // 
            this.lbNoControl.AutoSize = true;
            this.lbNoControl.Location = new System.Drawing.Point(12, 76);
            this.lbNoControl.Name = "lbNoControl";
            this.lbNoControl.Size = new System.Drawing.Size(129, 13);
            this.lbNoControl.TabIndex = 4;
            this.lbNoControl.Text = "No. de control del Cliente:";
            // 
            // tbNoControl
            // 
            this.tbNoControl.Location = new System.Drawing.Point(147, 73);
            this.tbNoControl.MaxLength = 5;
            this.tbNoControl.Name = "tbNoControl";
            this.tbNoControl.Size = new System.Drawing.Size(100, 20);
            this.tbNoControl.TabIndex = 5;
            this.tbNoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoControl_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 109);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(232, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(250, 112);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 7;
            this.lbTelefono.Text = "Telefono:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(321, 109);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.ReadOnly = true;
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 8;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(12, 144);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 9;
            this.lbDireccion.Text = "Direccion:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(73, 141);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ReadOnly = true;
            this.tbDireccion.Size = new System.Drawing.Size(144, 20);
            this.tbDireccion.TabIndex = 10;
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(12, 177);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(99, 13);
            this.lbClave.TabIndex = 11;
            this.lbClave.Text = "Clave del producto:";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(117, 174);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(100, 20);
            this.tbClave.TabIndex = 12;
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(15, 233);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.ReadOnly = true;
            this.tbProducto.Size = new System.Drawing.Size(100, 20);
            this.tbProducto.TabIndex = 13;
            // 
            // lbExistencia
            // 
            this.lbExistencia.AutoSize = true;
            this.lbExistencia.Location = new System.Drawing.Point(144, 236);
            this.lbExistencia.Name = "lbExistencia";
            this.lbExistencia.Size = new System.Drawing.Size(58, 13);
            this.lbExistencia.TabIndex = 14;
            this.lbExistencia.Text = "Existencia:";
            // 
            // tbExistencia
            // 
            this.tbExistencia.Location = new System.Drawing.Point(208, 233);
            this.tbExistencia.Name = "tbExistencia";
            this.tbExistencia.ReadOnly = true;
            this.tbExistencia.Size = new System.Drawing.Size(100, 20);
            this.tbExistencia.TabIndex = 15;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(364, 233);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 17;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(318, 236);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(40, 13);
            this.lbPrecio.TabIndex = 16;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(470, 236);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(52, 13);
            this.lbCantidad.TabIndex = 18;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(534, 233);
            this.tbCantidad.MaxLength = 5;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 19;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colPrecio,
            this.colCantidad,
            this.colTotal});
            this.dgProductos.Location = new System.Drawing.Point(15, 259);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersVisible = false;
            this.dgProductos.Size = new System.Drawing.Size(293, 150);
            this.dgProductos.TabIndex = 20;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Width = 50;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 50;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 50;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(321, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(37, 60);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(321, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(37, 60);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseMnemonic = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 437);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(177, 437);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 24;
            this.lbTotal.Text = "Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(225, 434);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 25;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(579, 437);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(265, 73);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarC.TabIndex = 6;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.Location = new System.Drawing.Point(265, 177);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarP.TabIndex = 13;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.UseVisualStyleBackColor = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 472);
            this.Controls.Add(this.btnBuscarP);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.tbExistencia);
            this.Controls.Add(this.lbExistencia);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbNoControl);
            this.Controls.Add(this.lbNoControl);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.tbFolio);
            this.Controls.Add(this.lbFolio);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFolio;
        private System.Windows.Forms.TextBox tbFolio;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label lbNoControl;
        private System.Windows.Forms.TextBox tbNoControl;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Label lbExistencia;
        private System.Windows.Forms.TextBox tbExistencia;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.Button btnBuscarP;
    }
}