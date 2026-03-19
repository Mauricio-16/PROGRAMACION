using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class JuegoDigital: VideoJuego
    {
        double Gigas { get; set; }
        public JuegoDigital(string titulo, double precio, Genero genero, double gigas) : base(titulo, precio, genero)
        {
            Gigas = gigas;
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Precio: ${Precio}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Tamaño: {Gigas} GB");
        }
    }
}
