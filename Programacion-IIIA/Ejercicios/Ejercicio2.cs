using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_IIIA.Ejercicios
{
    public class Ejercicio2
    {
        public static void Ejecutar()
        {
            
            // Pedir total de la cuenta
            Console.Write("Ingrese el total de la cuenta: ");
            double totalCuenta = double.Parse(Console.ReadLine());

            // Pedir porcentaje de propina
            Console.Write("¿Qué porcentaje de propina desea dejar? (10, 15, 20): ");
            int porcentaje = int.Parse(Console.ReadLine());

            // Calcular propina
            double propina = totalCuenta * porcentaje / 100;
            double totalFinal = totalCuenta + propina;

            // Mostrar resultados
            Console.WriteLine("\n===== RESUMEN DE PAGO =====");
            Console.WriteLine("Total cuenta: $" + totalCuenta);
            Console.WriteLine("Propina (" + porcentaje + "%): $" + propina);
            Console.WriteLine("Total a pagar: $" + totalFinal);

            // Mensaje si supera 100.000
            if (totalFinal > 100000)
            {
                Console.WriteLine("\n¡Gracias por tu generosidad! Tu aporte hace la diferencia ");
            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }    }
}
