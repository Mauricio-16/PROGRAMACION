using GlobalShip.Enum;
using GlobalShip.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "envios.csv";
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("--- SISTEMA GLOBALSHIP ---");
                Console.WriteLine("1. Nuevo Envío");
                Console.WriteLine("2. Ver Peso Total (Reporte)");
                Console.WriteLine("3. Buscar por Guía");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese Guía: ");
                        int guia = int.Parse(Console.ReadLine());
                        Console.Write("Destinatario: ");
                        string dest = Console.ReadLine();
                        Console.Write("Peso (kg): ");
                        double peso = double.Parse(Console.ReadLine());
                        Console.Write("Tipo (0: Nacional, 1: Internacional): ");
                        int tipoInt = int.Parse(Console.ReadLine());

                        Paquete paq = new Paquete(guia, dest, peso, (Tipo)tipoInt);
                        File.AppendAllText(ruta, paq.ToCSV() + Environment.NewLine);

                        Console.WriteLine("\n>> ¡ENVÍO GUARDADO EN ARCHIVO!");
                        break;

                    case "2":
                        if (File.Exists(ruta))
                        {
                            double pesoTotal = 0;
                            string[] lineas = File.ReadAllLines(ruta);
                            foreach (string linea in lineas)
                            {
                                var datos = linea.Split(';');
                                pesoTotal += double.Parse(datos[2]);
                            }
                            Console.WriteLine($"\nREPORTE: El peso total de carga es {pesoTotal} kg.");
                        }
                        else { Console.WriteLine("\nNo hay datos registrados."); }
                        break;

                    case "3":
                        Console.Write("Ingrese la Guía a buscar: ");
                        string buscar = Console.ReadLine();
                        bool hallado = false;

                        if (File.Exists(ruta))
                        {
                            foreach (string linea in File.ReadLines(ruta))
                            {
                                var datos = linea.Split(';');
                                if (datos[0] == buscar)
                                {
                                    Console.WriteLine($"\n[ENCONTRADO] Guía: {datos[0]} | Destino: {datos[1]} | Peso: {datos[2]}kg | Tipo: {datos[3]}");
                                    hallado = true;
                                    break;
                                }
                            }
                        }
                        if (!hallado) Console.WriteLine("\nNo se encontró ningún paquete con esa guía.");
                        break;

                    case "0":
                        continuar = false;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                }
                if (opcion != "0")
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}    