using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diario_Personal_con_Bitácora
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo = "diario.txt";

            Console.WriteLine("--- MI DIARIO PERSONAL ---");

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);
                int total = lineas.Length;

                if (total > 0)
                {
                    Console.WriteLine("\n[Últimas entradas]");
                    int inicio = total > 3 ? total - 3 : 0;

                    for (int i = inicio; i < total; i++)
                    {
                        Console.WriteLine(" > " + lineas[i]);
                    }
                }
            }

            Console.Write("\n¿Quién escribe?: ");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Hola {nombre}, ¿qué quieres registrar hoy?");
            string mensaje = Console.ReadLine();

            string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string entrada = $"[{fecha}] - {nombre.ToUpper()}: {mensaje}";

            File.AppendAllText(archivo, entrada + Environment.NewLine);

            Console.WriteLine("\n>> Entrada guardada. Presiona una tecla para salir.");
            Console.ReadKey();
        }
    }
}