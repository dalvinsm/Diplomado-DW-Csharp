using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioMonedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double cPesos, eqDolar;
            const int uCambio = 50;

            Console.Write("Ingrese la cantidad en pesos Dominicanos: ");
            cPesos = Double.Parse(Console.ReadLine());

            eqDolar = cPesos * uCambio;

            Console.WriteLine("\n {0:C2} Pesos equivale a {1:C2} dolares", cPesos, eqDolar);
            Console.ReadKey();
        }
    }
}
