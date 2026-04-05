using ParkingPro.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingPro
{
    class Carro : Vehiculo, Icobrable
    {
        public int NroPuertas { get; set; }
        public Carro(string p, string m, int nroPuertas) : base(p, m)
        {
            NroPuertas = nroPuertas;
        }
        public int CobrarTarifa(int minutos) => minutos * 100;
        public override void MostrarDatos() =>
            Console.WriteLine($"Carri Marca {Marca.ToUpper()} - {NroPuertas} Puertas");
    }
}
