using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_IIIA.Ejercicios
{
    public class Ejercicio4
    {
        /// <summary>
        /// Genera un correo corporativo en formato nombre.apellido@empresa.com
        /// </summary>
        public static void Ejecutar()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine().ToLower();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine().ToLower();

            string correo = $"{nombre}.{apellido}@empresa.com";

            Console.WriteLine($"Correo generado: {correo}");

            Console.ReadKey();
        }
    }
}
