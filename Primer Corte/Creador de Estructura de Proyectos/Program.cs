using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creador_de_Estructura_de_Proyectos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del proyecto: ");
            string nombreproyecto = Console.ReadLine();

            Directory.CreateDirectory(nombreproyecto);

            Directory.CreateDirectory(nombreproyecto + "/Documentos");
            Directory.CreateDirectory(nombreproyecto + "/Imagenes");
            Directory.CreateDirectory(nombreproyecto + "/Codigo");

            Console.Write("Ingrese una breve descripcion del proyecto: ");
            string descripcion = Console.ReadLine();

            string rutaArchivo = Path.Combine(nombreproyecto, "documentos", "readme.txt");

            File.WriteAllText(rutaArchivo, descripcion);

            Console.WriteLine("\nUbicación completa:");
            Console.WriteLine(Path.GetFullPath(nombreproyecto));
        }
    }
}
