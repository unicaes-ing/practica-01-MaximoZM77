using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Ejercicio5
    {
        public static void ejer5()
        {
            double ventas = 0, contador = 0, promedio=0;
            int i = 0;

            for ( i = 1; i < 4; i++)
            {
                Console.WriteLine("Ventas del trimestre"+i);
                ventas = Convert.ToDouble(Console.ReadLine());
                contador = contador + ventas;

            }
            promedio = contador / 3;
            Console.WriteLine("El promedio de ventas del año pasado es: " + promedio);
        }
    }
}
