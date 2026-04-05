using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_poo.Ejercicios
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double CapacidadTanque { get; set; }
        public double Rendimiento { get; set; }

        public Vehiculo(string modelo, double capacidad, double rendimiento)
        {
            Modelo = modelo;
            CapacidadTanque = capacidad;
            Rendimiento = rendimiento;
        }

        public double CalcularAutonomia()
        {
            return CapacidadTanque * Rendimiento;
        }

        public bool NecesitaCombustible(double distancia)
        {
            if (distancia > CalcularAutonomia())
                return true;
            else
                return false;
        }
    }
}
