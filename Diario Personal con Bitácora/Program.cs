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
            string nombreArchivo = "diario.txt";

            Console.WriteLine("=== BIENVENIDO A TU DIARIO DIGITAL ===");

            MostrarUltimasEntradas(nombreArchivo, 3);

            try
            {
                Console.Write("\nPor favor, ingresa tu nombre: ");
                string usuario = Console.ReadLine();

                Console.WriteLine($"\n¿Qué tienes en mente hoy, {usuario}?");
                string mensaje = Console.ReadLine();

                string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                string lineaLog = $"[{fechaHora}] - {usuario.ToUpper()}: {mensaje}{Environment.NewLine}";

                File.AppendAllText(nombreArchivo, lineaLog);

                Console.WriteLine("\n¡Entrada guardada con éxito!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError al acceder al disco: {ex.Message}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void MostrarUltimasEntradas(string ruta, int cantidad)
        {
            if (File.Exists(ruta))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(ruta);
                    if (lineas.Length > 0)
                    {
                        Console.WriteLine("\n--- Últimas entradas registradas ---");
                        var ultimas = lineas.Skip(Math.Max(0, lineas.Length - cantidad));
                        foreach (var linea in ultimas)
                        {
                            Console.WriteLine(linea);
                        }
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("No se pudieron leer las entradas anteriores.");
                }
            }
            else
            {
                Console.WriteLine("\n(El diario está vacío. ¡Eres el primero en escribir!)");
            }
        }
    }
}

