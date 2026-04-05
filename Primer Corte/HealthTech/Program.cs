using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CitaMedica> listaCitas = new List<CitaMedica>();
            string opcion = "";

            while (opcion !="0")
            {
                Console.WriteLine("--- MEDICAL MENU ---");
                Console.WriteLine("1. Agendar ");
                Console.WriteLine("2. Facturar ");
                Console.WriteLine("3. Cambiar especialidad ");
                Console.WriteLine("0. Salir ");
                Console.Write("\n Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Agendando cita...");
                        Console.Write("Ingrese el nombre del paciente: ");
                        string Paciente = Console.ReadLine();
                        Console.Write("Ingrese la especialidad ([0]General, [1]Pediatria, [2]Odontologia): ");
                        int Especialidad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el costo base de la cita: ");
                        double CostoBase = double.Parse(Console.ReadLine());

                        listaCitas.Add(new CitaMedica(Paciente, (Especialidad)Especialidad, CostoBase));
                        Console.WriteLine("Cita agendada exitosamente.");
                        break;

                    case "2":
                        Console.Write("Nombre del Paciente a facturar: ");
                        string buscar = Console.ReadLine();
                        CitaMedica cita = listaCitas.Find(c => c.Paciente.ToLower() == buscar.ToLower());
                        if (cita != null)
                        {
                            Console.WriteLine($"\n Paciente: {cita.Paciente}");
                            Console.WriteLine($"Especialidad: {cita.Especialidad}");
                            Console.WriteLine($"Costo Base: {cita.CostoBase}");
                            Console.WriteLine($"Costo con Descuento: {cita.AplicarDescuento()}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Paciente no encontrado.");
                        }
                        break;

                    case "3":
                        Console.Write("Nombre del Paciente: ");
                        string pacienteCambio = Console.ReadLine();
                        CitaMedica encontrada = listaCitas.Find(c => c.Paciente.ToLower() == pacienteCambio.ToLower());

                        if (encontrada != null)
                        {
                            Console.Write("Nueva Especialidad (0:Gen, 1:Ped, 2:Odo): ");
                            encontrada.Especialidad = (Especialidad)int.Parse(Console.ReadLine());
                            Console.WriteLine("Cambio realizado exitosamente");
                        }
                        else Console.WriteLine("Paciente no encontrado.");
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
