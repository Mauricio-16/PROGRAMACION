using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "catalogo juegos.txt";
            List<VideoJuego> juegos = new List<VideoJuego>();
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    string titulo = datos[0];
                    double precio = double.Parse(datos[1]);

                   Genero g = (Genero)Enum.Parse(typeof(Genero), datos[2]);
                    string tipo = datos[3];
                    if (tipo == "Digital")
                    {
                        double gigas = double.Parse(datos[4]);
                        Console.WriteLine($"Juego Digital: {titulo}, Precio: ${precio}, Género: {g}, Tamaño: {gigas} GB");
                        juegos.Add(new JuegoDigital(titulo, precio, g, gigas));
                    }
                    else if (tipo == "Físico")
                    {
                        double pesoEnvio = double.Parse(datos[4]);
                        Console.WriteLine($"Juego Físico: {titulo}, Precio: ${precio}, Género: {g}, Peso para envío: {pesoEnvio} kg");
                        juegos.Add(new JuegoFisico(titulo, precio, g, pesoEnvio));
                    }
                }
            }
            string opcion = "";

            while (opcion !="0")
            {
                Console.Clear();
                Console.WriteLine("----GAME STORE----");
                Console.WriteLine("1. Agregar Juego ");
                Console.WriteLine("2. Mostrar catalogo ");
                Console.WriteLine("0. Salir ");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el título del juego: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Ingrese el precio del juego: ");
                        double precio = double.Parse(Console.ReadLine());
                        Console.Write("Seleccione el género (0. Acción, 1. Aventura, 2. Estrategia): ");
                        int generoSeleccionado = int.Parse(Console.ReadLine());
                        Genero genero = (Genero)generoSeleccionado;
                        Console.Write("¿Es un juego digital? (s/n): ");
                        string tipoJuego = Console.ReadLine().ToLower();
                        if (tipoJuego == "s")
                        {
                            Console.Write("Ingrese el tamaño en GB: ");
                            double gigas = double.Parse(Console.ReadLine());
                            juegos.Add(new JuegoDigital(titulo, precio, genero, gigas));
                            File.AppendAllText(ruta, $"{titulo};{precio};{genero};Digital;{gigas}\n");
                        }
                        else
                        {
                            Console.Write("Ingrese el peso para envío en kg: ");
                            double pesoEnvio = double.Parse(Console.ReadLine());
                            juegos.Add(new JuegoFisico(titulo, precio, genero, pesoEnvio));
                            File.AppendAllText(ruta, $"{titulo};{precio};{genero};Físico;{pesoEnvio}\n");
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine("\n--- Catálogo de Juegos ---");
                        foreach (var juego in juegos)
                        {
                            juego.MostrarInformacion();
                            Console.WriteLine($"Precio con oferta: ${juego.CalcularOferta():0.00}\n");
                        }
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
