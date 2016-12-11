using System;
using System.Windows.Forms;
using Libreria.archivos.texto;

namespace Libreria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LoginManager l = new LoginManager();
            
            int estado = l.findUser(tbUser.Text, tbPass.Text);
            if (estado == LoginManager.ADMIN)
            {
                FrmAdmin main = new FrmAdmin();
                Hide();
                main.ShowDialog();
                Dispose();
            } else if (estado == LoginManager.USER)
            {
                FrmVentas ven = new FrmVentas();
                Hide();
                ven.ShowDialog();
                Dispose();
            }
            else
            {
                lbIncorrecta.Visible = true;
                //MessageBox.Show("Adios");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                //e.Handled = true;
            }
        }
    }
}
