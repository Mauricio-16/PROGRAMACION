using EjercicioTipoParcial2.ConcesionarioVehiculos.Enums;
using EjercicioTipoParcial2.ConcesionarioVehiculos.Interfaces;
using EjercicioTipoParcial2.ConcesionarioVehiculos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjercicioTipoParcial2
{
    class Program
    {
        static List<IVendible> inventarioVentas = new List<IVendible>();

        static void Main()
        {
            bool continuar = true;

            while (continuar)
            {
                try 
                {
                    Console.Clear();
                    Console.WriteLine("       SISTEMA DE GESTIÓN DE CONCESIONARIO      ");
                    Console.WriteLine("1. Registrar Auto");
                    Console.WriteLine("2. Registrar Motocicleta");
                    Console.WriteLine("3. Registrar Camión");
                    Console.WriteLine("4. Ver Reporte de Ventas");
                    Console.WriteLine("5. Salir");
                    Console.Write("\nSeleccione una opción: ");

                    string opcion = Console.ReadLine();

                    if (opcion == "5") { continuar = false; continue; }
                    if (opcion == "4") { MostrarReporte(); Console.ReadKey(); continue; }

                    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                    Console.Write("Marca: "); string marca = Console.ReadLine();
                    Console.Write("Modelo: "); string modelo = Console.ReadLine();
                    Console.Write("Año: "); int anio = int.Parse(Console.ReadLine());
                    Console.Write("Precio Base: "); decimal precio = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Combustible (0:Gasolina, 1:Diesel, 2:Electrico, 3:Hibrido): ");
                    TipoCombustible comb = (TipoCombustible)int.Parse(Console.ReadLine());

                    Console.WriteLine("Estado (0:Nuevo, 1:Usado, 2:Seminuevo): ");
                    EstadoVehiculo est = (EstadoVehiculo)int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case "1": 
                            Console.Write("Número de puertas: "); int puertas = int.Parse(Console.ReadLine());
                            Console.Write("¿Tiene Aire Acondicionado? (s/n): ");
                            bool aire = Console.ReadLine().ToLower() == "s";

                            Auto nuevoAuto = new Auto(id, marca, modelo, anio, precio, comb, est, puertas, aire);
                            inventarioVentas.Add(nuevoAuto);
                            break;

                        case "2": 
                            Console.Write("Cilindraje (cc): "); int cc = int.Parse(Console.ReadLine());
                            Console.Write("¿Es deportiva? (s/n): ");
                            bool deportiva = Console.ReadLine().ToLower() == "s";

                            Motocicleta nuevaMoto = new Motocicleta(id, marca, modelo, anio, precio, comb, est, cc, deportiva);
                            inventarioVentas.Add(nuevaMoto);
                            break;

                        case "3": 
                            Console.Write("Capacidad Carga (Toneladas): "); decimal carga = decimal.Parse(Console.ReadLine());
                            Console.Write("Número de ejes: "); int ejes = int.Parse(Console.ReadLine());

                            Camion nuevoCamion = new Camion(id, marca, modelo, anio, precio, comb, est, carga, ejes);
                            inventarioVentas.Add(nuevoCamion);
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                    Console.WriteLine("\n¡Vehículo registrado exitosamente!");
                    Console.WriteLine("Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();

                }
                catch (FormatException)
                {
                    Console.WriteLine("\nERROR: Entrada no válida. Asegúrese de usar números donde se solicita.");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nERROR INESPERADO: " + ex.Message);
                    Console.ReadKey();
                }
            }
        }

        static void MostrarReporte()
        {
            Console.Clear();
            Console.WriteLine("        REPORTE GENERAL DE VENTAS              ");

            if (inventarioVentas.Count == 0)
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            foreach (IVendible v in inventarioVentas)
            {

                if (v is Vehiculo vehiculoBase)
                {
                    vehiculoBase.MostrarEspecificaciones();
                }

                v.GenerarFacturaVenta();
                Console.WriteLine($"Comisión del vendedor: {v.CalcularComisionVendedor():C}");
            }
        }
    }
}
