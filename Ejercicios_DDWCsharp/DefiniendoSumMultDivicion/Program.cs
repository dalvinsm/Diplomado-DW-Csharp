using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniendoSumMultDivicion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, mult, div;
            string valor;

            Console.Write("Ingrese el primer numero: ");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);
            Console.Write("Ingrese el segundo numero: ");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);
            Console.Write("Ingrese el tercer numero: ");
            valor = Console.ReadLine();
            num3 = int.Parse(valor);
            Console.Write("Ingrese el cuarto numero: ");
            valor = Console.ReadLine();
            num4 = int.Parse(valor);

            suma = num1 + num2;
            mult = num3 * num4;
            div = num1 / num4;

            // Iniciamos la emprecion de los datos
            Console.Write("La Suma de los dos primeros numeros es: ");
            Console.WriteLine(suma);
            Console.Write("La Multiplicacion del tercero y el cuarto numero es: ");
            Console.WriteLine(mult);
            Console.Write("La Division del primero y el cuarto numero es: ");
            Console.WriteLine(div);
            Console.ReadKey();
        }
    }
}
