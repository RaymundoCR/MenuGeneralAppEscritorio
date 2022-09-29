using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MenuGeneral
{
    internal class Archivotxt
    {
        public static void MostrarTxt(string rutaFull)
        {
            try
            {
                if (!File.Exists(rutaFull))
                {
                    Console.WriteLine("El archivo no existe", rutaFull);
                }
                StreamReader objReader = new StreamReader(rutaFull);
                Console.WriteLine(objReader.ReadToEnd());
                objReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void MostrarCVS(String rutaFull)
        {
            try
            {
                int i = 0;
                foreach (string linea in File.ReadLines(rutaFull))
                {
                    Console.WriteLine(linea + "\n");
                    i++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static void EscribirTxt()
        {
            String rutaPrincipal = @"C:\ProyectC#\MenuGeneral\";
            string rutaFull;
            int agregarOno = 0;
            bool B1 = true;
            int tipoC = 0;
            Encoding tipoCodigo = Encoding.UTF7;

            Console.WriteLine("Por favor ingrese el nombre del archivo para ingresar datos\n\n");
            String nombreArchivo3 = Console.ReadLine();
            rutaFull = rutaPrincipal + nombreArchivo3;
            try
            {
                if (!File.Exists(rutaFull))
                {
                    Console.WriteLine("El archiovo {0} ha sido creado", rutaFull);
                }

                Console.WriteLine("¿Ingresara alumnos en un nuevo archivo o adicionara datos al existente?\n0.- NUEVO \n1.-Existente");
                int nuevoOadicion = Convert.ToInt32(Console.ReadLine());
                if (nuevoOadicion == 0)
                {
                    do
                    {
                        Console.WriteLine("Seleccione el tipo de codigo a escribir: \n0.- UTF7 \n1.-UTF8 \n2.- UNICOD \n3.- UTF32 \n4.- ASCII");
                        tipoC = Convert.ToInt32(Console.ReadLine());
                        switch (tipoC)
                        {
                            case 0:
                                tipoCodigo = Encoding.UTF7;
                                break;
                            case 1:
                                tipoCodigo = Encoding.UTF8;
                                break;
                            case 2:
                                tipoCodigo = Encoding.Unicode;
                                break;
                            case 3:
                                tipoCodigo = Encoding.UTF32;
                                break;
                            case 4:
                                tipoCodigo = Encoding.ASCII;
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Usted a cancelado el proceso\n\n");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Por favor selecciona un valor de la lista");
                                break;
                        }
                    } while (tipoC == 5);

                    File.Delete(rutaFull);
                    B1 = false;
                }


                bool B = true;
                while (B == true)
                {
                    Console.WriteLine("Ingresa el nombre");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el primer apellido");
                    String primerApellido = Console.ReadLine();
                    Console.WriteLine("Ingresa el segundo apellido");
                    String segundoApellido = Console.ReadLine();
                    Console.WriteLine("Ingresa la edad");
                    String edad = Console.ReadLine();
                    Console.WriteLine("Ingresa el estado");
                    String estado = Console.ReadLine();

                    StreamWriter objWriter = new StreamWriter(rutaFull, B1, tipoCodigo);
                    objWriter.WriteLine($"{nombre}, {primerApellido}, {segundoApellido}, {edad}, {estado}");
                    objWriter.Close();
                    Console.Clear();

                    Console.WriteLine("El archivo contiene los siguientes datos:\n");
                    StreamReader objReader = new StreamReader(rutaFull);
                    Console.WriteLine(objReader.ReadToEnd());
                    objReader.Close();

                    Console.WriteLine("¿Desea agregar otro alumno?\n0.- NO \n1.- SI");
                    agregarOno = Convert.ToInt32(Console.ReadLine());
                    if (agregarOno == 0) { B = false; }
                }
            }
            catch
            {
                StreamWriter objWriter = new StreamWriter(rutaFull);
                objWriter.Close();
            }
        }

        public static void Presentacion()
        {
            int op = 0;
            String rutaPrincipal = @"C:\ProyectC#\MenuGeneral\";
            String rutaFull;
            do
            {
                Console.WriteLine("¿Que desea hacer?\n\n 0.- Leer un archivo completo \n1.- Leer un archivo linea por linea \n2.- Ingresar datos a un Archivo Txt \n3.- Cancelar");
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Por favor ingrese el nombre del archivo para mostrarlo completo\n\n");
                        String nombreArchivo = Console.ReadLine();
                        rutaFull = rutaPrincipal + nombreArchivo;
                        MostrarTxt(rutaFull);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 1:
                        Console.WriteLine("Por favor ingrese el nombre del archivo para mostrarlo linea por linea\n\n");
                        String nombreArchivo2 = Console.ReadLine();
                        rutaFull = rutaPrincipal + nombreArchivo2;
                        MostrarCVS(rutaFull);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Usted ha cancelado el proceso");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Por facor seleccione una opcion del menu");
                        break;
                }
            } while (op == 2);
            
        }

        
    }
    //public class exepcionesUser : Exception
    //{
    //    public ArchivoNoEncontrado()
    //    {
    //        Console.WriteLine("El archivo no existe");
    //    }
    //}
}
