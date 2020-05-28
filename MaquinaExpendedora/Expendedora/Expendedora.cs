using Lata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validadores;

namespace Expendedora
{
    public class Expendedora
    {
        //Constantes de opciones fijas de las expendedoras, en caso de que la expendedora cambie de bebidas
        //se modifican estas constantes
        public const string opciones = ("CO1 - Coca Cola Regular \nCO2 - Coca Cola Zero \nSP1 - Sprite Regular \n" +
                            "SP2 - Sprite Zero \nFA1 - Fanta Regular \nFA2 - Fanta Zero \n" +
                            "Haga una consulta de stock para saber que bebidas contiene este maquina\n" +
                            "X - Salir" +
                            " ");
        public const string opcionesvalidasbebidas = ("CO1CO2SP1SP2FA1FA2");




        //variables de clase
        private List<Lata.Lata> _lata;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;


        public List<Lata.Lata> listadelata { get => _lata; }
        public string proveedor { get => _proveedor; }
        public int capacidad { get => _capacidad; }
        public double dinero { get => _dinero; }
        public bool encendida { get => _encendida; set => _encendida = value; }


        public Expendedora(string nombre)
        {
            this._lata = new List<Lata.Lata>();
            this._proveedor = proveedor;
            this._capacidad = capacidad;
            this._dinero = dinero;

        }


        //metodos de clase
        public void encendermaquina()

        {
            //Solicita al usuario que encienda la maquina
            Console.WriteLine("¿Desea encender la maquina? \nSi o No");
            string encendermaquina = Console.ReadLine();


            // En caso de encender variable de control pasa a true para continuar la operacion
            if (encendermaquina.ToUpper() == "SI")
            {
                encendida = true;
            }

        }

        public void apagarmaquina()

        {
            //Solicita al usuario que encienda la maquina
            Console.WriteLine("¿Desea apagar la maquina? \nSi o No");
            string encendermaquina = Console.ReadLine();


            // En caso de encender variable de control pasa a true para continuar la operacion
            if (encendermaquina.ToUpper() == "SI")
            {
                encendida = false;
            }

        }

        public void mostraropciones()
        {
            Console.WriteLine(opciones);
        }


        public void agregarlata()

        {
            bool flag = true;

            do
            {
                Console.WriteLine("¿Que bebida desea agregar? \n");
                mostraropciones();
                string bebidaseleccionada = Console.ReadLine();
                if (Validadores.Validadores.EsOpcionValidaBebida(bebidaseleccionada, opcionesvalidasbebidas))
                {
                    listadelata.Add(new Lata.Lata() 
                    {codigo = bebidaseleccionada, 
                     nombre = Validadores.Validadores.ObtenerNombreBebida(bebidaseleccionada),
                     sabor = Validadores.Validadores.ObtenerSaborBebida(bebidaseleccionada), 
                     precio, //VER PORQUE NO ME TOMA PRECIO
                     volumen  //VER PORQUE NO ME TOMA VOLUMEN
                    });
                    Console.WriteLine("Lata Agregada");
                    flag = false;
                }
            }
            while (flag == true);

        }


    }
}

            
            
               



        





