using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nº2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, resta, multip, multiplicacion, DatoNº1, DatoNº2;


            Console.WriteLine("Ingrese el primer dato: ");
            DatoNº1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo dato: ");
            DatoNº2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            suma = DatoNº1 + DatoNº2;

            resta = DatoNº1 - DatoNº2;

            multip = suma * resta;

            multiplicacion = DatoNº1 * 2 - DatoNº2;

            Console.WriteLine("El resultado de la suma es: R/ " + suma);
            Console.WriteLine("El resultado de la resta es: R/ " + resta);
            Console.WriteLine("El resultado de (a+b)*(a-b) es:  R/ " + multip);
            Console.WriteLine("El resultado de a2-b es: R/ " + multiplicacion);
            Console.ReadKey();


        }
    }
}
