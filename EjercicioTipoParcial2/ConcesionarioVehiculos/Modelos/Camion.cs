using EjercicioTipoParcial2.ConcesionarioVehiculos.Enums;
using EjercicioTipoParcial2.ConcesionarioVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial2.ConcesionarioVehiculos.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(int id, string marca, string modelo, int anio, decimal precio, TipoCombustible comb, EstadoVehiculo est, decimal carga, int ejes)
            : base(id, marca, modelo, anio, precio, comb, est)
        {
            CapacidadCarga = carga;
            NumeroEjes = ejes;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Tipo: Camión | Carga: {CapacidadCarga} Ton | Ejes: {NumeroEjes}");
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500);
        }

        public decimal CalcularComisionVendedor() => CalcularPrecioFinal() * 0.07m;

        public void GenerarFacturaVenta()
        {
            Console.WriteLine($"FACTURA CAMIÓN: {Marca} {Modelo} - Total: {CalcularPrecioFinal():C}");
        }
    }
}
