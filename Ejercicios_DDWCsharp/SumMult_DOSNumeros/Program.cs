using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMult_DOSNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Suma, Mult;
            string valor;

            Console.WriteLine("*** Suma y Multiplicacion de Dos Numeros ***");
            Console.WriteLine();

            Console.WriteLine("Ingrese el Primer Numero");
            valor = Console.ReadLine();
            Num1 = int.Parse(valor);

            Console.WriteLine("Ingrese el Segundo Numero");
            valor = Console.ReadLine();
            Num2 = int.Parse(valor);

            Suma = Num1 + Num2;
            Mult = Num1 * Num2;

            //Iniciamos la imprecion de los datos
            Console.WriteLine();
            Console.Write("La suma de los Numeros es: ");
            Console.WriteLine(Suma);
            Console.Write("La Multiplicacion de los Numeros es: ");
            Console.WriteLine(Mult);
            Console.ReadKey();
        }
    }
}
