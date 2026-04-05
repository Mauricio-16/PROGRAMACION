using EjercicioParcial3.SistemaRestaurante.Enums;
using EjercicioParcial3.SistemaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial3.SistemaRestaurante.Modelos
{
    public class Entrada : Plato, IPreparable
    {
        public bool EsFria { get; set; }
        public int Porciones { get; set; }

        public Entrada(int id, string nom, decimal pre, TipoComida t, NivelDificultad d, bool fria, int por)
            : base(id, nom, pre, t, d)
        {
            EsFria = fria;
            Porciones = por;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int minutos = EsFria ? 10 : 20;
            return TimeSpan.FromMinutes(minutos);
        }

        public decimal CalcularCostoTotal() => PrecioBase + (Porciones * 1.5m);

        public void GenerarOrdenCocina()
        {
            string temp = EsFria ? "FRÍA" : "CALIENTE";
            Console.WriteLine($"[ORDEN COCINA] Entrada {temp}: {Nombre} - Cantidad: {Porciones}");
        }
    }
}
