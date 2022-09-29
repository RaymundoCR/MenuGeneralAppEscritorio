using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Poliza
    {   
        public static PolizaResultado Calcular(DateTime FechaInicioVigencia, int TipoPeriodo, int CantPeriodos, decimal SumaAsegurada, DateTime fechaNacimiento, int genero)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            PolizaResultado objPolizaResultado = new PolizaResultado();
            if(TipoPeriodo == 0)
            {
                objPolizaResultado.FechaTermino = (FechaInicioVigencia.AddYears(CantPeriodos));
            }
            if (TipoPeriodo == 1)
            {
                objPolizaResultado.FechaTermino = (FechaInicioVigencia.AddMonths(CantPeriodos));
            }
            if (TipoPeriodo == 3)
            {
                objPolizaResultado.FechaTermino = (FechaInicioVigencia.AddDays(CantPeriodos));
            }

            //-------------------------------------------------------------------------------------

            
            TimeSpan fechaDuracion = objPolizaResultado.FechaTermino - FechaInicioVigencia;
            decimal dias = fechaDuracion.Days;

            decimal[,] tabISR = new decimal[,]
            {
                {0, 20, 0, 0.05m },
                {21, 30, 0, 0.1m },
                {31, 40, 0, 0.4m },
                {41, 40, 0, 0.5m },
                {51, 60, 0, 0.65m },
                {61, 150, 0, 0.85m },
                {0, 20, 1, 0.05m },
                {21, 30, 1, 0.1m },
                {31, 40, 1, 0.4m },
                {41, 50, 1, 0.55m },
                {51, 60, 1, 0.7m },
                {61, 130, 1, 0.9m }
            };
            decimal factor = 0.0m;
            Console.WriteLine(tabISR.Length);
            for (int i=0; i<tabISR.Length; i++)
            {
                int min = 0;
                int max = 0;
                int gen = 0;
                min = Convert.ToInt32(tabISR[i, 0]);
                max = Convert.ToInt32(tabISR[i, 1]);
                gen = Convert.ToInt32(tabISR[i, 2]);
                if (Enumerable.Range(min, max).Contains(edad) && gen == genero)
                {
                    factor = tabISR[i, 3];
                    break;
                }
            }
            

            objPolizaResultado.Prima = ((SumaAsegurada) * (factor)) * (dias / 360);

            return objPolizaResultado;
        }

        public static void Presentacion()
        {
            Console.WriteLine("Proporciona la fecha de inicio de vigencia");
            DateTime iniciVigencia = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingresar el tipo de periodo que desea adquirir \n0.- Años \n1.- Meses \n2.- Dias");
            int tipoPeriodo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de periodo");
            int CantPeriodos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proporciona la suma asegurada");
            decimal SumaAsegurada = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Proporciona la fecha de Nacimiento del asegurado");
            DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Proporciona el genero del asegurado \n0.- Femenino \n1.- Masculino");
            int genero = Convert.ToInt32(Console.ReadLine());
            //DateTime iniciVigencia = Convert.ToDateTime("01/04/2021");
            //int tipoPeriodo = 1;
            //int CantPeriodos = 3;
            //decimal SumaAsegurada = 100000.00m;
            //DateTime fechaNacimiento = Convert.ToDateTime("01/01/1000");
            //int genero = 1;
            PolizaResultado result = Poliza.Calcular(iniciVigencia, tipoPeriodo, CantPeriodos, SumaAsegurada, fechaNacimiento, genero);
            Console.WriteLine($"La fecha de vencimiento es: {result.FechaTermino}");
            Console.WriteLine($"La Prima es: {Math.Round(result.Prima)}");
        } 
    }
}
