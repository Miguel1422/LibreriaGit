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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cl = new FrmCliente();
            this.Hide();
            cl.ShowDialog();
            this.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos ven = new FrmProductos();
            this.Hide();
            ven.ShowDialog();
            this.Show();
        }
    }
}
