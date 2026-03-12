using EjercicioParcial3.SistemaRestaurante.Enums;
using EjercicioParcial3.SistemaRestaurante.Interfaces;
using EjercicioParcial3.SistemaRestaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial3
{
    internal class Program
    {
        static List<IPreparable> comandaDelDia = new List<IPreparable>();

        static void Main()
        {
            bool continuar = true;
            while (continuar)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("=== SISTEMA DE RESTAURANTE ===");
                    Console.WriteLine("1. Registrar Entrada\n2. Registrar Plato Principal\n3. Registrar Postre\n4. Ver Pedidos\n5. Salir");
                    Console.Write("\nOpcion: ");
                    string opcion = Console.ReadLine();

                    if (opcion == "5") break;
                    if (opcion == "4") { MostrarComanda(); continue; }

                    Console.Write("Ingrese el ID del plato: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Nombre del plato: "); string nombre = Console.ReadLine();
                    Console.Write("Precio Base: "); decimal precio = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Tipo (0:Veg, 1:Vegana, 2:Carnivora, 3:Mariscos): ");
                    TipoComida tipo = (TipoComida)int.Parse(Console.ReadLine());

                    Console.WriteLine("Dificultad (0:Facil, 1:Intermedio, 2:Avanzado): ");
                    NivelDificultad dif = (NivelDificultad)int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("¿Es frio? (s/n): "); bool frio = Console.ReadLine().ToLower() == "s";
                            comandaDelDia.Add(new Entrada(id, nombre, precio, tipo, dif, frio, 1));
                            break;
                        case "2":
                            Console.Write("Proteina: "); string prot = Console.ReadLine();
                            comandaDelDia.Add(new PlatoPrincipal(id, nombre, precio, tipo, dif, prot, true));
                            break;
                        case "3":
                            Console.Write("Calorias: "); int cal = int.Parse(Console.ReadLine());
                            comandaDelDia.Add(new Postre(id, nombre, precio, tipo, dif, true, cal));
                            break;
                    }
                    Console.WriteLine("\n¡Plato registrado!");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nError: " + ex.Message);
                    Console.ReadKey();
                }
            }
        }

        static void MostrarComanda()
        {
            Console.Clear();
            Console.WriteLine("=== ORDENES EN COCINA ===");
            foreach (IPreparable item in comandaDelDia)
            {
                if (item is Plato p) p.MostrarInformacionNutricional();
                item.GenerarOrdenCocina();
                Console.WriteLine($"Tiempo: {item.CalcularTiempoPreparacion().TotalMinutes} min");
            }
            Console.ReadKey();
        }
    }
}
