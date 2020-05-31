using Lata;
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
    public partial class Frmagregar : Form
    { 

         private Expendedora.Expendedora _maq;
    
        public Frmagregar(Expendedora.Expendedora maq)
        {
        _maq = maq;
        InitializeComponent();
        }

       
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_maq.listadelata.Count == _maq.capacidad)

                { MessageBox.Show("Capacidad maxima alcanzada"); }

                else
                {
                    _maq.listadelata.Add(new Lata.Lata()
                    {
                        codigo = comboBox1.Text.Substring(0, 3),
                        nombre = Validadores.Validadores.ObtenerNombreBebida(comboBox1.Text.Substring(0, 3)),
                        sabor = Validadores.Validadores.ObtenerSaborBebida(comboBox1.Text.Substring(0, 3)),
                        precio = Validadores.Validadores.ValidaDouble(textBox1.Text),
                        volumen = Validadores.Validadores.ValidaDouble(textBox2.Text)
                    });
                    MessageBox.Show("Ha agregado una " + comboBox1.Text + " \nPrecio: $"
                        + textBox1.Text + " Volumen: " + textBox2.Text + " ML");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Precio o volumen ingresados incorrectamente, por favor " +
                    "ingresar un numero mayor a cero en ambos campos");
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();

        }

        
    }
}
