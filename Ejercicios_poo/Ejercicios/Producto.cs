using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_poo.Ejercicios
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }

        public Producto(string nombre, string codigo, decimal precio)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            CantidadStock = 0;
        }

        public void AgregarStock(int cantidad)
        {
            CantidadStock += cantidad;
        }

        public decimal VenderProducto(int cantidad)
        {
            if (cantidad <= CantidadStock)
            {
                CantidadStock -= cantidad;
                return Precio * cantidad;
            }
            else
            {
                Console.WriteLine("No hay suficiente stock.");
                return 0;
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Codigo: " + Codigo);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Stock: " + CantidadStock);
        }
    }
}
