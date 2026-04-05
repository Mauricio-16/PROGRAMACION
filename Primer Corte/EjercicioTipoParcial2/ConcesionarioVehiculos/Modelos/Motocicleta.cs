using EjercicioTipoParcial2.ConcesionarioVehiculos.Enums;
using EjercicioTipoParcial2.ConcesionarioVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial2.ConcesionarioVehiculos.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Motocicleta(int id, string marca, string modelo, int anio, decimal precio, TipoCombustible comb, EstadoVehiculo est, int cilindraje, bool deportiva)
            : base(id, marca, modelo, anio, precio, comb, est)
        {
            Cilindraje = cilindraje;
            EsDeportiva = deportiva;
        }

        public override void MostrarEspecificaciones()
        {
            base.MostrarEspecificaciones();
            Console.WriteLine($"Tipo: Motocicleta | Cilindraje: {Cilindraje}cc | Deportiva: {(EsDeportiva ? "Sí" : "No")}");
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (EsDeportiva ? (decimal)Cilindraje * 10 : 0);
        }

        public decimal CalcularComisionVendedor() => CalcularPrecioFinal() * 0.05m;

        public void GenerarFacturaVenta()
        {
            Console.WriteLine($"FACTURA MOTO: {Marca} {Modelo} - Total: {CalcularPrecioFinal():C}");
        }
    }
}
