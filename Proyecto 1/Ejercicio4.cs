using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
   public  class ejercicio4
    {
        public static void ejer4()
        {
            int num1 = 0;
            Console.WriteLine("Escriba un numero entero por favor");
            num1 = Convert.ToInt32(Console.ReadLine());
            Math.Sqrt(num1);
            Console.ReadKey();
            Console.WriteLine("La raiz cuadrada de tu numero es: {0}  ",Math.Sqrt(num1));
            Console.ReadKey(); 
        

        }
    }
}
