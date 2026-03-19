using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPro
{
    abstract class Vehiculo
    {
        public string Placa { get; set;  } 
        public string Marca { get; set; }

        public Vehiculo(string placa, string marca)
        {
            Placa = placa;
            Marca = marca;
        }
        public abstract void MostrarDatos();
    }
}
