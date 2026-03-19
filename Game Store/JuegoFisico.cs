using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class JuegoFisico : VideoJuego
    {
        double PesoEnvio { get; set; }
        public JuegoFisico(string titulo, double precio, Genero genero, double pesoEnvio) : base(titulo, precio, genero)
        {
            PesoEnvio = pesoEnvio;
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Precio: ${Precio}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Peso para envío: {PesoEnvio} kg");
        }
    }
}
