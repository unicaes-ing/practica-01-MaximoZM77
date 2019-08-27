using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre,raza;
            int edad;
            System.Console.WriteLine("Cual es el nombre de su perro?");
            nombre = ("Meraxes");
            System.Console.WriteLine("Mi perro se llama {0}",nombre);
            System.Console.ReadKey();
            System.Console.WriteLine("Cual es la raza de perro?");
            raza = ("Husky");
            System.Console.WriteLine("Mi perro es raza {0}", raza);
            System.Console.ReadKey();
            System.Console.WriteLine("Cual es la edad de su perro?");
            edad = 2;
            System.Console.WriteLine("Mi perro tiene {0} años", edad);
            System.Console.ReadKey();

            System.Console.WriteLine("//////////////////////Ejercicio2/////////////////////");
            ejer2.ejercicio2();
            System.Console.WriteLine("//////////////////////Ejercicio3/////////////////////");
            ejercicio3.ejer3();
            System.Console.WriteLine("//////////////////////Ejercicio4/////////////////////");
            ejercicio4.ejer4();
            System.Console.WriteLine("//////////////////////Ejercicio5/////////////////////");
            Ejercicio5.ejer5();
            System.Console.WriteLine("//////////////////////Ejercicio6/////////////////////");
            Ejercicio6.ejer6();
            Console.ReadKey();








        }
    }
}
