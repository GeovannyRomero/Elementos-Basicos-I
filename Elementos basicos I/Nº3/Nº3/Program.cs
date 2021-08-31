using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nº3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nº1, nº2, dividir;

            Console.WriteLine("Ingrese el primer dato: ");
            nº1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo dato: ");
            nº2 = Convert.ToInt32(Console.ReadLine());


            if (nº2 <= 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                dividir = nº1 / nº2;

                Console.WriteLine("Resultado: {0}", dividir);

            }
            Console.ReadKey();
        }
    }
}