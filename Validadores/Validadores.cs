using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validadores
{
    public static class Validadores
    {
        //devuelve si la validacion está bien o no
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
            switch (opcion.Substring(1,2))
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
            switch (opcion.Substring(3, 1))
            {
                case "1":
                    return "Regular";

                case "2":
                    return "Zero";
                default:
                    return "Sabor Inexistente";


            }

        }
    }
}
