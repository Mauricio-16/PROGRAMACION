using GlobalShip.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShip.Modelo
{
    internal class Paquete
    {
        int guia { get; set; }
        string destinatario { get; set; }
        double peso { get; set; }
        public Tipo tipo { get; set; }

        public Paquete(int guia, string destinatario, double peso, Tipo tipo)
        {
            this.guia = guia;
            this.destinatario = destinatario;
            this.peso = peso;
            this.tipo = tipo;
        }

        public string ToCSV() => $"{guia};{destinatario};{peso};{tipo}";
    }
}
