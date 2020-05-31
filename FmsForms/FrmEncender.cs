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

        public partial class FrmEncender : Form
        {
            private Expendedora.Expendedora _maq;
            

            public FrmEncender(Expendedora.Expendedora maq)
            {
                _maq = maq;
                InitializeComponent();
            }

            
        private void btnencender_Click(object sender, EventArgs e)
        {
            if (_maq.capacidad != 0)
            {
                this.Owner.Show();
                this.Hide();
            }
            else
            {
                FrmDatosInciales f = new FrmDatosInciales(_maq);
                f.Show();
                this.Hide();
            }
        }

     
    }
}
