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
    public partial class Frmstock : Form
    {
        private Expendedora.Expendedora _maq;

        List<string> lista = new List<string>();

        public Frmstock(Expendedora.Expendedora maq)
        {
            _maq = maq;
            InitializeComponent();
        }


        private void btnvolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void Frmstock_Load(object sender, EventArgs e)
        {

            foreach (Lata.Lata lata in _maq.listadelata)
            {
                lista.Add(lata.nombre + " - " + lata.sabor + " $" +
                    lata.precio + " / $/L" + lata.getprecioporlitro());

            }


            liststock.DataSource = lista;

        }
    }
}
