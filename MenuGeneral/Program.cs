using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MenuGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.WriteLine("SELECIONE UNA OPCION \n1.- Hola Mundo \n2.- Declaración de variables \n3.- Cadena priumera letra a mayusculas  \n4.- Poliza \n5.- Mostrar Archivo Txt \n6.- Agregar Alumno Txt \n7.- Calcular ISR \n8.- Condicionales \n9.- Ciclos \n10.- Cuerpo Expresión \n11.- Pase por Valor y referencia \n12.- Manejo de Excepciones \n13.- Listas \n14.- Nivel de Acceso \nF.- Terminar");
                opcion = Console.ReadLine();    
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 1\n\n");
                        Arreglos.Cadenas();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 2\n\n");
                        Arreglos.Enteros();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 3\n\n");
                        Console.WriteLine("Ingrese una cadena a convertir");
                        string cadena = Console.ReadLine();
                        Arreglos.ConvierteATipoOracion(cadena);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 4\n\n");
                        Poliza.Presentacion();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 5\n\n");
                        Archivotxt.Presentacion();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 6\n\n");
                        Archivotxt.EscribirTxt();
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 7\n\n");
                        ISR.Presentacion();
                        Console.Clear();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 8\n\n");
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 9\n\n");
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 10\n\n");
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 11\n\n");
                        break;
                    case "12":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 12\n\n");
                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 13\n\n");
                        break;
                    case "14":
                        Console.Clear();
                        Console.WriteLine("Usted selecciono la opcion 14\n\n");
                        break;
                    case "F":
                        Console.Clear();
                        Console.WriteLine("Usted a salido de la áplicación\n\n");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("La opcion seleccionada no existe\n\n");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != "F");
        }
    }
}
