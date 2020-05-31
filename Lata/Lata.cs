using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lata
{
    public class Lata
    {
        string _codigo;
        string _nombre;
        string _sabor;
        double _precio;
        double _volumen;

        public string codigo { get => _codigo; set => _codigo = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string sabor { get => _sabor; set => _sabor = value; }
        public double precio { get => _precio; set => _precio = value; }
        public double volumen { get => _volumen; set => _volumen = value; }


    public double getprecioporlitro()
        {
            return 1000 / precio * volumen;
        }

    }
}