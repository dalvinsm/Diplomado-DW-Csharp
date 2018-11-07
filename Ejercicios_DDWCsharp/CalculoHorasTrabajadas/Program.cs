using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoHorasTrabajadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costohoras, sueldo;
            string linea;
            Console.Write("Ingrese las horas trabajadas por el Soporte Tecnico: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);

            Console.Write("Ingrese el pago por horas: ");
            linea = Console.ReadLine();
            costohoras = int.Parse(linea);

            costohoras = float.Parse(linea);
            sueldo = horasTrabajadas * costohoras;

            // Iniciamos la emprecion de los datos
            Console.Write("El sueldo total del Soporte Tecnico es: ");
            Console.WriteLine(sueldo);
            Console.ReadKey();

        }
    }
}
