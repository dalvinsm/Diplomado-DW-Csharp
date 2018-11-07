using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlArticulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad;
            float Precio, Total;
            string linea;
            Console.Write("Ingrese la cantidad de articulos a llevar: ");
            linea = Console.ReadLine();
            Cantidad = int.Parse(linea);

            Console.Write("Ingrese el valor unitario del producto: ");
            linea = Console.ReadLine();
            Precio = float.Parse(linea);

            Total = Precio * Cantidad;

            // Iniciamos la emprecion de los datos
            Console.Write("El total a pagar es: ");
            Console.WriteLine(Total);
            Console.ReadKey();
        }
    }
}
