using EjercicioParcial3.SistemaRestaurante.Enums;
using EjercicioParcial3.SistemaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioParcial3.SistemaRestaurante.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string ProteinaPrincipal { get; set; }
        public bool IncluyeGuarnicion { get; set; }

        public PlatoPrincipal(int id, string nom, decimal pre, TipoComida t, NivelDificultad d, string prot, bool guar)
            : base(id, nom, pre, t, d)
        {
            ProteinaPrincipal = prot;
            IncluyeGuarnicion = guar;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int extra = (int)Dificultad * 15;
            return TimeSpan.FromMinutes(30 + extra);
        }

        public decimal CalcularCostoTotal() => PrecioBase + (IncluyeGuarnicion ? 5.50m : 0);

        public void GenerarOrdenCocina()
        {
            Console.WriteLine($"[ORDEN COCINA] Plato Fuerte: {Nombre} | Proteína: {ProteinaPrincipal}");
            if (IncluyeGuarnicion) Console.WriteLine(" -> Con guarnición incluida.");
        }
    }
}
