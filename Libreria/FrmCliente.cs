using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void tbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back 
                && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space 
                && e.KeyChar != '#' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && !char.IsDigit(e.KeyChar)&& e.KeyChar != '@' 
                && e.KeyChar != '.' && e.KeyChar != '_' 
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != '+'
                && e.KeyChar != '(' && e.KeyChar != ')'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
