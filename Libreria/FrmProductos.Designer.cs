namespace Libreria
{
    partial class FrmProductos
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
            this.lbIsbn = new System.Windows.Forms.Label();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.tbEditorial = new System.Windows.Forms.TextBox();
            this.lbEditorial = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.tbCopias = new System.Windows.Forms.TextBox();
            this.lbCopias = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbIsbn
            // 
            this.lbIsbn.AutoSize = true;
            this.lbIsbn.Location = new System.Drawing.Point(12, 41);
            this.lbIsbn.Name = "lbIsbn";
            this.lbIsbn.Size = new System.Drawing.Size(35, 13);
            this.lbIsbn.TabIndex = 0;
            this.lbIsbn.Text = "ISBN:";
            // 
            // tbIsbn
            // 
            this.tbIsbn.Location = new System.Drawing.Point(80, 38);
            this.tbIsbn.MaxLength = 17;
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(125, 20);
            this.tbIsbn.TabIndex = 2;
            this.tbIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIsbn_KeyPress);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(80, 64);
            this.tbTitulo.MaxLength = 40;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(125, 20);
            this.tbTitulo.TabIndex = 3;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(12, 67);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(38, 13);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Título:";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(80, 90);
            this.tbAutor.MaxLength = 40;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(125, 20);
            this.tbAutor.TabIndex = 4;
            this.tbAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAutor_KeyPress);
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(12, 93);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(35, 13);
            this.lbAutor.TabIndex = 4;
            this.lbAutor.Text = "Autor:";
            // 
            // tbEditorial
            // 
            this.tbEditorial.Location = new System.Drawing.Point(80, 116);
            this.tbEditorial.MaxLength = 40;
            this.tbEditorial.Name = "tbEditorial";
            this.tbEditorial.Size = new System.Drawing.Size(125, 20);
            this.tbEditorial.TabIndex = 5;
            // 
            // lbEditorial
            // 
            this.lbEditorial.AutoSize = true;
            this.lbEditorial.Location = new System.Drawing.Point(12, 119);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(47, 13);
            this.lbEditorial.TabIndex = 6;
            this.lbEditorial.Text = "Editorial:";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(80, 12);
            this.tbClave.MaxLength = 5;
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(125, 20);
            this.tbClave.TabIndex = 1;
            this.tbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClave_KeyPress);
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(12, 15);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(37, 13);
            this.lbClave.TabIndex = 8;
            this.lbClave.Text = "Clave:";
            // 
            // tbCopias
            // 
            this.tbCopias.Location = new System.Drawing.Point(80, 142);
            this.tbCopias.MaxLength = 5;
            this.tbCopias.Name = "tbCopias";
            this.tbCopias.Size = new System.Drawing.Size(125, 20);
            this.tbCopias.TabIndex = 9;
            this.tbCopias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCopias_KeyPress);
            // 
            // lbCopias
            // 
            this.lbCopias.AutoSize = true;
            this.lbCopias.Location = new System.Drawing.Point(12, 145);
            this.lbCopias.Name = "lbCopias";
            this.lbCopias.Size = new System.Drawing.Size(42, 13);
            this.lbCopias.TabIndex = 10;
            this.lbCopias.Text = "Copias:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(80, 207);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(13, 171);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 12;
            this.lbPrecio.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(80, 168);
            this.tbPrecio.MaxLength = 5;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(125, 20);
            this.tbPrecio.TabIndex = 10;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbCopias);
            this.Controls.Add(this.lbCopias);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.tbEditorial);
            this.Controls.Add(this.lbEditorial);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.lbIsbn);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIsbn;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox tbEditorial;
        private System.Windows.Forms.Label lbEditorial;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox tbCopias;
        private System.Windows.Forms.Label lbCopias;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
    }
}