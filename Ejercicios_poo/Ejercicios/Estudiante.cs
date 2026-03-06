using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_poo.Ejercicios
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double[] Notas { get; set; }

        public Estudiante(string nombre, string materia, double[] notas)
        {
            Nombre = nombre;
            Materia = materia;
            Notas = notas;
        }

        public double CalcularPromedio()
        {
            return (Notas[0] + Notas[1] + Notas[2]) / 3;
        }

        public string EstadoFinal()
        {
            if (CalcularPromedio() >= 3.0)
                return "Aprobado";
            else
                return "Reprobado";
        }
    }
}
