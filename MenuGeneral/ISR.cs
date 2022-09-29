using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class ISR
    {
        static decimal[,] _tablaISR = new decimal[21, 5];
        public static void CargarTabla(string rutaFull)
        {
            try
            {
                string[] sep = new string[6];

                if (!File.Exists(rutaFull))
                {
                    Console.WriteLine("El archivo no existe", rutaFull);
                }

                string[] lineas = File.ReadAllLines(rutaFull);
                int i = 0;
                foreach (string line in lineas)
                {
                    sep = line.Split(',');
                    _tablaISR[i, 0] = Convert.ToDecimal(sep[1]);
                    _tablaISR[i, 1] = Convert.ToDecimal(sep[2]);
                    _tablaISR[i, 2] = Convert.ToDecimal(sep[3]);
                    _tablaISR[i, 3] = Convert.ToDecimal(sep[4]);
                    _tablaISR[i, 4] = Convert.ToDecimal(sep[5]);
                    i ++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void Calcular(decimal sueldoMensual)
        {
            decimal linMin = 0m;
            decimal linMax = 0m;
            decimal cuota = 0m;
            decimal Execliminf = 0m;
            decimal Subsidio = 0m;
            decimal sueldoQuincenal = sueldoMensual / 2;

            for (int i = 0; i < _tablaISR.Length; i++)
            {
                linMin = _tablaISR[i, 0];
                linMax = _tablaISR[i, 1];
                if (sueldoQuincenal < linMax && sueldoQuincenal > linMin)
                {
                    cuota = _tablaISR[i, 2];
                    Execliminf = _tablaISR[i, 3];
                    Subsidio = _tablaISR[i, 4];
                    break;
                }
            }

            
            decimal sQuinLim = (sueldoQuincenal - linMin);
            decimal limExecliminf = sQuinLim * (Execliminf / 100);
            decimal finISR = limExecliminf + (cuota - Subsidio);

            Console.WriteLine($"El ISR a pagar es: {finISR}");
        }

        public static void Presentacion()
        {
            string rutaA = @"C:\ProyectC#\MenuGeneral\";
            string nameArchivo;
            Console.WriteLine("Digite el nombre del archivo");
            nameArchivo = Console.ReadLine();
            String rutaFull = rutaA + nameArchivo;
            CargarTabla(rutaFull);
            Console.WriteLine("Ingrese el sueldo mensual");
            decimal sueldoMensual = Convert.ToDecimal(Console.ReadLine());
            Calcular(sueldoMensual);
            Console.ReadKey();
        }
    }

}
