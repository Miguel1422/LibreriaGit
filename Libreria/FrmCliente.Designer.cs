namespace Libreria
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.lbClave = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(15, 23);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(37, 13);
            this.lbClave.TabIndex = 0;
            this.lbClave.Text = "Clave:";
            // 
            // tbClave
            // 
            this.tbClave.Location = new System.Drawing.Point(76, 20);
            this.tbClave.MaxLength = 5;
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(200, 20);
            this.tbClave.TabIndex = 1;
            this.tbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClave_KeyPress);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(15, 75);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 2;
            this.lbDireccion.Text = "Direccion:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(15, 49);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(15, 127);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(40, 13);
            this.lbFecha.TabIndex = 10;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(15, 153);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 8;
            this.lbTelefono.Text = "Telefono:";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(15, 101);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(41, 13);
            this.lbCorreo.TabIndex = 6;
            this.lbCorreo.Text = "Correo:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(76, 46);
            this.tbNombre.MaxLength = 40;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 11;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(76, 72);
            this.tbDireccion.MaxLength = 40;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(200, 20);
            this.tbDireccion.TabIndex = 12;
            this.tbDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDireccion_KeyPress);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(76, 98);
            this.tbCorreo.MaxLength = 40;
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(200, 20);
            this.tbCorreo.TabIndex = 13;
            this.tbCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCorreo_KeyPress);
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(76, 124);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 14;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(76, 150);
            this.tbTelefono.MaxLength = 15;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(200, 20);
            this.tbTelefono.TabIndex = 15;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(311, 20);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(122, 150);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 16;
            this.pbImagen.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(336, 176);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 23);
            this.btnImagen.TabIndex = 17;
            this.btnImagen.Text = "Cargar";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(18, 226);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 18;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(99, 226);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 19;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(180, 226);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 20;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(261, 226);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 21;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbCorreo);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.lbClave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnModifica;
    }
}