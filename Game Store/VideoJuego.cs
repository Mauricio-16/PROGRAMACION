using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    abstract class VideoJuego : IPromocion
    {
        public string Titulo { get; set; }
        public double Precio { get; set; }
        public Genero Genero { get; set; }
        public VideoJuego(string titulo, double precio, Genero genero)
        {
            Titulo = titulo;
            Precio = precio;
            Genero = genero;
        }
        public double CalcularOferta()
        {
            double descuento = 0;
            switch (Genero)
            {
                case Genero.Estrategia:
                    descuento = 0.15; 
                    break;
                default:
                    descuento = 0.0; 
                    break;
            }
            return Precio * (1 - descuento);
        }
        public abstract void MostrarInformacion();
    }
}
