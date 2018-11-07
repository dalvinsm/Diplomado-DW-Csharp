using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSuperficieCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorLado;
            int calSuperficie;
            String linea;

            Console.Write("Ingrese el valor del Lado del Cuadrado: ");
            linea = Console.ReadLine();
            valorLado = int.Parse(linea);

            calSuperficie = valorLado * (valorLado * valorLado);

            Console.Write("La superficie del Cuadrado es: ");
            Console.WriteLine(calSuperficie);
            Console.ReadKey();
        }
    }
}
