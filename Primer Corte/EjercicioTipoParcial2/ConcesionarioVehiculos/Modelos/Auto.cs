using EjercicioTipoParcial2.ConcesionarioVehiculos.Enums;
using EjercicioTipoParcial2.ConcesionarioVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial2.ConcesionarioVehiculos.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAire { get; set; }

        public Auto(int id, string mar, string mod, int anio, decimal pre, TipoCombustible c, EstadoVehiculo e, int puertas, bool aire)
            : base(id, mar, mod, anio, pre, c, e)
        {
            NumeroPuertas = puertas; TieneAire = aire;
        }

        public decimal CalcularPrecioFinal() => PrecioBase + (TieneAire ? 2000 : 0);
        public decimal CalcularComisionVendedor() => CalcularPrecioFinal() * 0.03m;

        public void GenerarFacturaVenta()
        {
            Console.WriteLine($"FACTURA AUTO: {Marca} - Total: {CalcularPrecioFinal():C}");
        }
    }
}
