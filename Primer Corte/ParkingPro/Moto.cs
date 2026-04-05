using ParkingPro.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPro
{
    class Moto: Vehiculo, Icobrable
    {
        public int Cilindraje { get; set; }
        public Moto (string p, string m, int cilindraje) : base(p, m)
        {
            Cilindraje = cilindraje;
        }
        public int CobrarTarifa(int minutos) => minutos * 50;
        public override void MostrarDatos()=>
            Console.WriteLine($"Moto marca {Marca.ToUpper()} - {Cilindraje}CC");
    }
}
