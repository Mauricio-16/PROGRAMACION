using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_IIIA.Ejercicios
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            // Pedir Nickname
            Console.Write("Ingresa tu Nickname: ");
            string nickname = Console.ReadLine();

            // Pedir nivel de experiencia
            Console.Write("Ingresa tu nivel de experiencia (1-100): ");
            int nivel = int.Parse(Console.ReadLine());

            // Pedir si es Premium
            Console.Write("¿Tienes suscripción Premium? (true/false): ");
            bool premium = bool.Parse(Console.ReadLine());

            // Determinar rango según nivel
            string rango;

            if (nivel <= 20)
                rango = "Principiante";
            else if (nivel <= 50)
                rango = "Intermedio";
            else if (nivel <= 80)
                rango = "Avanzado";
            else
                rango = "Experto";

            // Mostrar resultado
            Console.WriteLine("\n===== PERFIL GAMER =====");
            Console.WriteLine("Bienvenido, " + nickname + "!");
            Console.WriteLine("Nivel: " + nivel + " (" + rango + ")");
            Console.WriteLine("Suscripción Premium: " + (premium ? "Sí" : "No"));

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
