using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FmsForms
{
    public partial class FrmMenu : Form
    {
        private Expendedora.Expendedora _maq;
        public FrmMenu(Expendedora.Expendedora maq)
        {
            _maq = maq;
            InitializeComponent();
        }




            private void btnapagar_Click(object sender, EventArgs e)
        {
            FrmEncender f = new FrmEncender(_maq);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnopciones_Click(object sender, EventArgs e)
        {

            Frmopciones f = new Frmopciones();
            f.Owner = this;
            f.Show();
            this.Hide();

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Frmagregar f = new Frmagregar(_maq);
            f.Owner = this;
            f.Show();
            this.Hide();

        }

        private void btnextraer_Click(object sender, EventArgs e)
        {
            FrmExtraer f = new FrmExtraer(_maq);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_maq.getbalance());

        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            Frmstock f = new Frmstock(_maq);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void FrmMenu_Load_1(object sender, EventArgs e)
        {
            label2.Text = _maq.proveedor;
        }
    }
}
