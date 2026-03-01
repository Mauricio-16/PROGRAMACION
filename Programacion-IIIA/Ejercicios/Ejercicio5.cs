using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_IIIA.Ejercicios
{
    public class Ejercicio5
    {
        /// <summary>
        /// Simula el comportamiento de un semáforo.
        /// </summary>
        public static void Ejecutar()
        {
            Console.Write("Ingrese el color del semáforo (Verde, Amarillo, Rojo): ");
            string color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "verde":
                    Console.WriteLine("Sigue adelante.");
                    break;

                case "amarillo":
                    Console.WriteLine("Prepárate para frenar.");
                    break;

                case "rojo":
                    Console.WriteLine("¡Detente!");
                    break;

                default:
                    Console.WriteLine("Color no válido.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
