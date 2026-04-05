using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria_Pets
{
    class Paciente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public Especie Especie { get; set; }

        public Paciente (int id, string nombre, int edad, Especie especie)
        {
            ID = id;
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
        }
        public string ToCSV() => $"{ID};{Nombre};{Edad}";
        
    }
}
