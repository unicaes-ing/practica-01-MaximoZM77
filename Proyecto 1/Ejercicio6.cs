using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class Ejercicio6
    {
        public static void ejer6()

        {
            string nombre;
            double sueldo = 0, ISSS = 0.03, Renta = 0.10, AFP = 0.0625, nuevosueldo=0;
            Console.WriteLine("Escriba su nombre");
            Console.ReadLine();
            Console.WriteLine("Escriba su sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El descuento de ISSS de su sueldo es:" );
            ISSS = sueldo * ISSS;
            nuevosueldo = sueldo - ISSS;
            Console.WriteLine("Su nuevo sueldo es de:" + nuevosueldo.ToString("C2"));
            Console.ReadKey();
            Console.WriteLine("El descuento de la renta es ");
            Renta = sueldo * Renta;
            nuevosueldo = sueldo - Renta;
            Console.WriteLine("Su nuevo sueldo es de:" + nuevosueldo.ToString("C2"));
            Console.ReadKey();
            Console.WriteLine("El descuento de la AFP es");
            AFP = sueldo * AFP;
            nuevosueldo = sueldo - AFP;
            Console.WriteLine("Su nuevo sueldo es de: " + nuevosueldo.ToString("C2"));
            Console.ReadKey();

        }
       
          
    }
}
