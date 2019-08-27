using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    public class ejer2
    {
        public static void ejercicio2()
        {

            string nombre, sueldo, correo, cargo, FDC;
            int edad = 25;
            System.Console.WriteLine("Escriba su nombre");
            nombre=("Juan Perez");
            System.Console.WriteLine("Mi nombre es {0}", nombre);
            System.Console.ReadKey();
            System.Console.WriteLine("Cuanto es su sueldo?");
            sueldo = ("$1000");
            System.Console.WriteLine("Mi sueldo es de {0}", sueldo);
            System.Console.ReadKey();
            System.Console.WriteLine("Cual es su correo electronico?");
            correo = ("Juan@gmail.com");
            System.Console.WriteLine("Mi correo es {0}", correo);
            System.Console.ReadKey();
            System.Console.WriteLine("Cual es el cargo en su trabajo?");
            cargo = ("Presidente");
            System.Console.WriteLine("Realizo el cargo de {0}", cargo);
            System.Console.ReadKey();
            System.Console.WriteLine("Cual es la fecha en la que lo contraron?");
            FDC = ("16/07/2019");
            System.Console.WriteLine("Me contraron en la siguiente fecha {0}", FDC);
            System.Console.ReadKey();
            System.Console.WriteLine("Que edad tiene?");
            System.Console.WriteLine("Tengo {0} años", edad);
            Console.ReadKey();
            

        } 
       
        

    }
}
