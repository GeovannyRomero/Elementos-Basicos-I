using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nº4
{
    class Program
    {
        static void Main(string[] args)
        {
            double Centigrados, Fahrenheit;

            Console.WriteLine("Ingrese la cantidad en Grados Centigrados: ");
            Centigrados = Convert.ToDouble(Console.ReadLine());

            Fahrenheit = (9 / 5) * Centigrados + 32;

            Console.WriteLine("Grados Fahrenheit: " + Fahrenheit);
            Console.ReadKey();
        }
    }
}