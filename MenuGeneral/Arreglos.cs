using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MenuGeneral
{
    internal class Arreglos
    {
        private static int length;

        public static void Cadenas()
        {
            Console.WriteLine("Proporciona tu nombre completo");
            String nameFull = Console.ReadLine();
            string[] nameSepadaro = nameFull.Split(' ');
            Console.WriteLine("\nHola ");
            foreach( var i in nameSepadaro)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("");
            Console.WriteLine("Apellido Vertical");
            char[] primerApellido = nameSepadaro[1].ToCharArray();
            foreach( var i in primerApellido)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.ReadKey();
        }

        public static void Enteros()
        {
            int[] datos = new int[5];
            int i, mayor = 0, j = 0;

            Console.WriteLine("Ingrese 5 valores enteros para encontrar el numero mayor");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el entero numero {i + 1}");
                datos[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (j < 5)
            {
                if (datos[j] > mayor)
                    mayor = datos[j];
                j++;
            }
            Console.WriteLine($"El entero mayor es: {mayor}");
            Console.ReadKey();
        }

        public static void ConvierteATipoOracion(string cadena)
        {
            string[] cadenaSeparada = cadena.Split(' ');
            foreach (var i in cadenaSeparada)
            {
                Console.Write($"{char.ToUpper(i[0]) + i.Substring(1)} ");
            }

        }
    }
}
