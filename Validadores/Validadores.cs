using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validadores
{
    public static class Validadores
    {

        // AGREGAR VALIDACION QUE NO SEA TEXTO
        public static double ValidaDouble()
        {
            //Valido que sea mayor que cero porque no se usan numeros negativos
            
            double c = double.Parse(Console.ReadLine());

            do
            {
                if (c > 0)
                {
                    return c;
                    
                }
                else
                {
                    Console.WriteLine("El valor es incorrecto, por favor ingrese nuevamente");
                    c = double.Parse(Console.ReadLine());
                    
                }
            }
            while (c <= 0);

            return 0;

        }

        // AGREGAR VALIDACION QUE NO SEA TEXTO
        public static int ValidaInt()
        {
            //Valido que sea mayor que cero porque no se usan numeros negativos
            int c = int.Parse(Console.ReadLine());

            do
            {
                if (c > 0)
                {
                    return c;

                }
                else
                {
                    Console.WriteLine("El numero ingresado es incorrecto, por favor ingrese nuevamente");
                    c = int.Parse(Console.ReadLine());

                }
            }
            while (c <= 0);

            return 0;

        }

        public static bool EsOpcionValida(string input, string opcionesValidas)
        {
            // manejamos expciones
            try
            {
                // validamos algo
                if (string.IsNullOrEmpty(input)  // es nulo o vacío
                    || input.Length > 1          // tiene más de un caracter       
                    || !opcionesValidas.ToUpper().Contains(input.ToUpper())) // no está dentro de las opciones válidas
                {
                    return false;
                }

                return true;
            }
            // podemos capturar más exceptions asi mostramos errpores más personalizados
            // en este caso no nos importa arrojar una ex porque decidimos que el método devuelva T o F
            catch
            {
                Console.WriteLine("Opcion Invalida");
                return false;
            }
        }


        public static bool EsOpcionValidaBebida(string input, string opcionesValidas)
        {
    
            try
            {

                if (string.IsNullOrEmpty(input)  
                    || input.Length > 3               
                    || !opcionesValidas.ToUpper().Contains(input.ToUpper())) 
                {
                    return false;
                }

                return true;
            }

            catch
            {

                Console.WriteLine("Bebida Invalida");
                return false;
            }
        }

        public static string ObtenerNombreBebida(string opcion)

        {
                                

            switch (opcion.ToUpper().Substring(0, 2))
            {
                case "CO":
                    return "Coca Cola";
                   
                case "SP":
                    return "Sprite";

                case "FA":
                    return "Fanta";
                default:
                    return "Bedida Inexistente";
                
                


            };


        }
             

        public static string ObtenerSaborBebida(string opcion)

        {

            switch (opcion.Substring(2, 1).ToUpper())


            {
                case "1":
                    return "Regular";

                case "2":
                    return "Zero";
                default:
                    return "Sabor Inexistente";


            }

        }
    
        public static double ObtenerPrecioBebida()
        {
            double precio = 0;
            Console.WriteLine("¿Cual es el precio de la bebida que va a ingresar?");
            precio = ValidaDouble();
            return precio;

        }

        public static double ObtenerVolumenBebida()
        {
            double volumen = 0;
            Console.WriteLine("¿Cual es el volumen de la bebida que va a ingresar? \n" +
                              "Por favor ingresarlo en Mililitros");
            volumen = ValidaDouble();
            return volumen;

        }

    }
}
