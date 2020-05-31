using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validadores;

namespace FmsForms
{
    public partial class FrmDatosInciales : Form
    {
        private Expendedora.Expendedora _maq;
        public FrmDatosInciales(Expendedora.Expendedora maq)
        {
            _maq = maq;
            InitializeComponent();
        }

        private void btnaceptar1_Click(object sender, EventArgs e)
        {
            try
            {
                _maq.proveedor = txtprov.Text;
                _maq.capacidad = Validadores.Validadores.ValidaInt(txtcap.Text);
                _maq.dinero = Validadores.Validadores.ValidaInt(txtdin.Text);
                FrmMenu f = new FrmMenu(_maq);
                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Capacidad o dinero incial ingresados incorrectamente, por favor " +
                  "ingresar un numero mayor a cero en ambos campos");

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtprov.Clear();
            txtcap.Clear();
            txtdin.Clear();

        }
    }
}
