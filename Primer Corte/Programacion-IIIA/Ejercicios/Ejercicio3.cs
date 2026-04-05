using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_IIIA.Ejercicios
{
    public class Ejercicio3
    {
        /// <summary>
        /// Controla el aforo máximo de una discoteca.
        /// </summary>
        public static void Ejecutar()
        {
            const int AforoMaximo = 50;

            Console.Write("¿Cuántas personas quieren entrar? ");
            int personas = int.Parse(Console.ReadLine());

            if (personas <= AforoMaximo)
            {
                Console.WriteLine("Bienvenidos, pueden ingresar.");
            }
            else
            {
                int exceso = personas - AforoMaximo;
                Console.WriteLine($"No hay cupo. Deben salir {exceso} personas para poder ingresar.");
            }

            Console.ReadKey();
        }
    }
}
