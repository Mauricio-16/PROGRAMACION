using EjercicioParcial3.SistemaRestaurante.Enums;
using EjercicioParcial3.SistemaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial3.SistemaRestaurante.Modelos
{
    public class Postre : Plato, IPreparable
    {
        public bool ContieneLactosa { get; set; }
        public int CaloriasPorPorcion { get; set; }

        public Postre(int id, string nom, decimal pre, TipoComida t, NivelDificultad d, bool lac, int cal)
            : base(id, nom, pre, t, d)
        {
            ContieneLactosa = lac;
            CaloriasPorPorcion = cal;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int extra = ContieneLactosa ? 5 : 0;
            return TimeSpan.FromMinutes(25 + extra);
        }

        public decimal CalcularCostoTotal() => PrecioBase + (CaloriasPorPorcion > 400 ? 3.0m : 0);

        public void GenerarOrdenCocina()
        {
            string advertencia = ContieneLactosa ? "CON LACTOSA" : "SIN LACTOSA";
            Console.WriteLine($"[ORDEN COCINA] Postre: {Nombre} ({advertencia}) - Calorías: {CaloriasPorPorcion}");
        }
    }
}
