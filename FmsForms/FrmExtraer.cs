using Lata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FmsForms
{

    public partial class FrmExtraer : Form
    {
        private Expendedora.Expendedora _maq;

        List<string> lista = new List<string>();
        List<string> listabebidas = new List<string>();
        List<double> listaprecios = new List<double>();

        public FrmExtraer(Expendedora.Expendedora maq)
        {
            _maq = maq;
            InitializeComponent();
        }

        private void FrmExtraer_Load(object sender, EventArgs e)
        {
            //Armo ListBox con las bebidas
            foreach (Lata.Lata lata in _maq.listadelata)
            {
                lista.Add(lata.nombre + " - " + lata.sabor + " $" +
                    lata.precio + " / $/L" + lata.getprecioporlitro());

            }

            lstopcionbebida.DataSource = lista;

            foreach (Lata.Lata lata in _maq.listadelata)
            {
                listaprecios.Add(lata.precio);

            }

            foreach (Lata.Lata lata in _maq.listadelata)
            {
                listabebidas.Add(lata.nombre + " - " + lata.sabor);

            }

            lstopcionbebida.DataSource = lista;
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                //Valido que el dinero sea suficiente
                if (Validadores.Validadores.ValidaDouble(textdinero.Text) < listaprecios.ElementAt(lstopcionbebida.SelectedIndex))

                { MessageBox.Show("El dinero no alcanza para la bebida seleccionada"); }

                else

                {
                    double vuelto = Validadores.Validadores.ValidaDouble(textdinero.Text) - listaprecios.ElementAt(lstopcionbebida.SelectedIndex);

                    //Borro de la lista de latas la bebida que sacan
                    _maq.listadelata.RemoveAt(lstopcionbebida.SelectedIndex);

                    _maq.dinero = _maq.dinero + listaprecios.ElementAt(lstopcionbebida.SelectedIndex);

                    //Mensaje de bebida entregada
                    MessageBox.Show("Entregando " + listabebidas.ElementAt(lstopcionbebida.SelectedIndex) +
                        " \nSu vuelto es: " + vuelto);


                    // ACtualizo listbox
                    lista.Clear();
                    foreach (Lata.Lata lata in _maq.listadelata)
                    {
                        lista.Add(lata.nombre + " - " + lata.sabor + " $" +
                            lata.precio + " / $/L" + lata.getprecioporlitro());

                    }
                    lstopcionbebida.DataSource = null;
                    lstopcionbebida.DataSource = lista;

                    listaprecios.Clear();
                    foreach (Lata.Lata lata in _maq.listadelata)
                    {
                        listaprecios.Add(lata.precio);

                    }
                    listabebidas.Clear();
                    foreach (Lata.Lata lata in _maq.listadelata)
                    {
                        listabebidas.Add(lata.nombre + " - " + lata.sabor);

                    }

                    lstopcionbebida.DataSource = lista;

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Opciones ingresadas no validas");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
