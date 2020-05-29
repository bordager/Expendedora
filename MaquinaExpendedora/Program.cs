using Expendedora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Validadores;

namespace Consola
{
    class Program
    {


        static void Main(string[] args)
        {
            //declaro constante de menu
            const string menu = "1) Mostrar Bebidas Disponibles \n2) Ingresa Lata \n3) Extraer Lata \n4) Obtener Balance " +
                        "\n5) Mostrar Stock \nX) Apagar Maquina";

            

            //declaro objeto expendedora
            Expendedora.Expendedora maquina = new Expendedora.Expendedora("maquina");

            
            maquina.encendermaquina();

            if (maquina.encendida == true)

            {
                maquina.iniciarmaquina();

                Console.WriteLine("Bienvenido");

                do
                {

                    Console.WriteLine("¿En que lo puedo ayudar?");
                    Console.WriteLine(menu); //mostramos el menu

                    try
                    {
                        //input de usuario
                        string opcionSeleccionada = Console.ReadLine();

                        //Validacion de opcion valida
                        if (Validadores.Validadores.EsOpcionValida(opcionSeleccionada, "12345X"))
                        {
                            //En caso de seleccion apagar maquina se llama al metodo apagar maquina
                            if (opcionSeleccionada.ToUpper() == "X")
                            {
                                maquina.apagarmaquina();
                            }

                            // switch de opciones validas
                            switch (opcionSeleccionada)
                            {
                                case "1":
                                    Console.WriteLine("Nuestras maquinas cuentan con las siguientes opciones \n");
                                    maquina.mostraropciones();
                                    Console.WriteLine("Ingrese una tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();

                                    break;

                                case "2":
                                    maquina.agregarlata();
                                    Console.WriteLine("Ingrese una tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "3":
                                    if (maquina.estavacia() == true)
                                    { Console.WriteLine("La maquina se encuentra vacia"); }

                                    else
                                    {
                                        
                                    }
                                     break;

                                case "4":
                                    Console.WriteLine(maquina.getbalance());
                                    break;

                                case "5":// No anda
                                    if (maquina.estavacia() == true)
                                    { Console.WriteLine("La maquina se encuentra vacia"); }// No anda

                                    else
                                    {
                                        foreach (Lata.Lata lata in maquina.listadelata)// No anda
                                        {
                                            Console.WriteLine(lata);  // No anda
                                        }
                                    }    
                                    break;

                            }

                        }
                        else
                        {
                            Console.WriteLine("Opción inválida.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    // en caso de error de ejecucion entra a este catch
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error durante la ejecución del comando. Por favor intente nuevamente. Mensaje: " + ex.Message);
                        Console.WriteLine("Ingrese una tecla para continuar.");


                        Console.ReadKey();
                        Console.Clear();
                    }


                }
                while (maquina.encendida == true);

                Console.WriteLine("Gracias por usar nuestras maquinas expendedoras.");
                Console.ReadKey();
            
            }

            Console.WriteLine("Que tenga un buen dia.");
            Console.ReadKey();
        }

    }
}

