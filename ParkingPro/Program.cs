using ParkingPro.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] parqueadero = new Vehiculo[5];
            int contador = 0;
            string opcion = "";

            while (opcion != "0")
            {
                Console.WriteLine("\n--- MENU PARKINGPRO ---");
                Console.WriteLine("1. Registrar Vehículo");
                Console.WriteLine("2. Consultar por Placa");
                Console.WriteLine("3. Ver todos");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (contador < 5)
                        {
                            Console.Write("Tipo (1:Carro, 2:Moto): ");
                            string tipo = Console.ReadLine();
                            Console.Write("Placa: ");
                            string p = Console.ReadLine();
                            Console.Write("Marca: ");
                            string m = Console.ReadLine();

                            switch (tipo)
                            {
                                case "1":
                                    Console.Write("Nro Puertas: ");
                                    int puertas = int.Parse(Console.ReadLine());
                                    parqueadero[contador] = new Carro(p, m, puertas);
                                    contador++;
                                    break;
                                case "2":
                                    Console.Write("Cilindraje: ");
                                    int cil = int.Parse(Console.ReadLine());
                                    parqueadero[contador] = new Moto(p, m, cil);
                                    contador++;
                                    break;
                                default:
                                    Console.WriteLine("Tipo no válido.");
                                    break;
                            }
                        }
                        else Console.WriteLine("Parqueadero lleno.");
                        break;

                    case "2":
                        Console.Write("Ingrese placa a buscar: ");
                        string buscar = Console.ReadLine().ToUpper();
                        bool hallado = false;

                        for (int i = 0; i < contador; i++)
                        {
                            if (parqueadero[i].Placa.ToUpper() == buscar)
                            {
                                Console.Write(">> ENCONTRADO: ");
                                parqueadero[i].MostrarDatos();
                                // Uso de la interfaz para calcular
                                Icobrable cobro = (Icobrable)parqueadero[i];
                                Console.WriteLine($"Tarifa (1h): ${cobro.CobrarTarifa(60)}");
                                hallado = true;
                                break;
                            }
                        }
                        if (!hallado) Console.WriteLine("Vehículo no encontrado.");
                        break;

                    case "3":
                        Console.WriteLine("\n--- LISTADO ---");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.Write($"{i + 1}. [{parqueadero[i].Placa.ToUpper()}] ");
                            parqueadero[i].MostrarDatos();
                        }
                        break;
                }
            }
        }
    }
}
