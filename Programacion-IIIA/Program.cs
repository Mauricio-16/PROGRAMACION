using Programacion_IIIA.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_IIIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===== EJERCICIOS TEMA 1 ===== \n1. Perfil de Usuario Gamer. \n2. Calculadora de Propina Solidaria. \n3. Control de Aforo en Eventos. \n4. Generador de Correos Corporativos. \n5. Simulador de Semáforo Inteligente.\n ");
                Console.Write("Elija una opción (1-5): ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Ejercicio1.Ejecutar();
                        break;

                    case 2:
                        Ejercicio2.Ejecutar();
                        break;

                    case 3:
                        Ejercicio3.Ejecutar();
                        break;

                    case 4:
                        Ejercicio4.Ejecutar();
                        break;

                    case 5:
                        Ejercicio5.Ejecutar();
                        break;

                }
            }
        }
    }
}
