using EjercicioTipoParcial2.ConcesionarioVehiculos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial2.ConcesionarioVehiculos.Modelos
{
    public abstract partial class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected Vehiculo(int id, string marca, string modelo, int anio, decimal precio, TipoCombustible comb, EstadoVehiculo est)
        {
            Id = id; Marca = marca; Modelo = modelo; Anio = anio;
            PrecioBase = precio; Combustible = comb; Estado = est;
        }
    }

    public abstract partial class Vehiculo
    {
        public virtual void MostrarEspecificaciones()
        {
            Console.WriteLine($"\n[{Id}] {Marca} {Modelo} {Anio} | Estado: {Estado}");
        }
    }
}
