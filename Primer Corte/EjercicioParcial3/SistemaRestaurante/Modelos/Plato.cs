using EjercicioParcial3.SistemaRestaurante.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial3.SistemaRestaurante.Modelos
{
    public abstract partial class Plato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoComida Tipo { get; set; }
        public NivelDificultad Dificultad { get; set; }

        protected Plato(int id, string nombre, decimal precio, TipoComida tipo, NivelDificultad dif)
        {
            Id = id;
            Nombre = nombre;
            PrecioBase = precio;
            Tipo = tipo;
            Dificultad = dif;
        }
    }

    public abstract partial class Plato
    {
        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine($"\n>>> PLATO: {Nombre} <<<");
            Console.WriteLine($"Tipo de Dieta: {Tipo}");
            Console.WriteLine($"Complejidad en Cocina: {Dificultad}");
        }
    }
}
