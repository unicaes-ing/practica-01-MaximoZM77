using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class ejercicio3
    {
        public static void ejer3()
        {
            double num1=0, num2=0, r=0;
            int opc = 0;
            Console.WriteLine("Coloque el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coloque el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.suma");
            Console.WriteLine("2.resta");
            Console.WriteLine("3.multiplicacion");
            Console.WriteLine("4.division");
            Console.WriteLine("que desea hacer");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    r = num1 + num2;
                    break;
                case 2:
                    r = num1 - num2;
                    break;
                case 3:
                    r = num1 * num2;
                    break;
                case 4:
                    r = num1 / num2;
                    break;
                default:
                    break;
            }
            Console.WriteLine("La respuesta de la operacion es: " + r);

            Console.ReadKey();

            
        }
   
            

        
    }
}
