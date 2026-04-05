using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_Contactos_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = "contactos.csv";

            Console.Write("Nombre: ");
            string nom = Console.ReadLine();

            Console.Write("Teléfono: ");
            string tel = Console.ReadLine();

            Console.Write("Correo: ");
            string cor = Console.ReadLine().Trim().ToLower();

            Contacto nuevo = new Contacto(nom, tel, cor);
            File.AppendAllText(ruta, nuevo.ToCSV() + Environment.NewLine);

            Console.WriteLine(">> Contacto Guardado.");

            Console.Write("\n¿Desea listar contactos? (si/no): ");
            if (Console.ReadLine().ToLower() == "si")
            {
                if (File.Exists(ruta))
                {
                    Console.WriteLine("\n--- LISTA DE CONTACTOS ---");
                    foreach (string linea in File.ReadAllLines(ruta))
                    {
                        string[] datos = linea.Split(';');
                        Console.WriteLine($"Nombre: {datos[0]} | Tel: {datos[1]} | Email: {datos[2]}");
                    }
                }
            }
        }
    }
}
