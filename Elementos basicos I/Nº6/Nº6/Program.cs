using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nº6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Calificacion1, Calificacion2, Calificacion3;
            int NotaFinal;
            int valoraplicado1, valoraplicado2, valoraplicado3;


            Console.WriteLine("Ingrese la Calificacion Nº1:");
            Calificacion1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Calificacion Nº2:");
            Calificacion2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Calificacion Nº3:");
            Calificacion3 = int.Parse(Console.ReadLine());

            valoraplicado1 = 35 * Calificacion1 / 100;
            valoraplicado2 = 30 * Calificacion2 / 100;
            valoraplicado3 = 25 * Calificacion3 / 100;

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("la Primera Calificacion segun el valor aplicado del 35% es: " + valoraplicado1);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("La Segunda Calificacion segun el valor aplicado del 30% es: " + valoraplicado2);
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("La Tercera Calificacion segun el valor aplicado del 25% es: " + valoraplicado3);
            Console.WriteLine("------------------------------------------------------------------------------");

            NotaFinal = valoraplicado1 + valoraplicado2 + valoraplicado3;
            Console.WriteLine("Su Calificacion final que obtenida es: " + NotaFinal);
            Console.ReadKey();
        }
    }
}