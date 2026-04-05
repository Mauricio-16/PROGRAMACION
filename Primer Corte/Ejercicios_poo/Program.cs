using Ejercicios_poo.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1. Cajero Automatico");
                Console.WriteLine("2. Control de Inventario");
                Console.WriteLine("3. Calculadora de Calificaciones");
                Console.WriteLine("4. Gestion de Viajes");
                Console.WriteLine("5. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Cajero();
                        break;
                    case 2:
                        Inventario();
                        break;
                    case 3:
                        Estudiante();
                        break;
                    case 4:
                        Vehiculo();
                        break;
                }

            } while (opcion != 5);
        }

        static void Cajero()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            CuentaBancaria cuenta = new CuentaBancaria(nombre);

            int op;

            do
            {
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Retirar");
                Console.WriteLine("4. Salir");
                Console.Write("Opcion: ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    cuenta.ConsultarSaldo();
                }
                else if (op == 2)
                {
                    Console.Write("Cantidad a depositar: ");
                    decimal cantidad = decimal.Parse(Console.ReadLine());
                    cuenta.Depositar(cantidad);
                }
                else if (op == 3)
                {
                    Console.Write("Cantidad a retirar: ");
                    decimal cantidad = decimal.Parse(Console.ReadLine());
                    cuenta.Retirar(cantidad);
                }

            } while (op != 4);
        }

        static void Inventario()
        {
            Console.Write("Nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Codigo: ");
            string codigo = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Producto producto = new Producto(nombre, codigo, precio);

            Console.Write("Cantidad a agregar: ");
            int agregar = int.Parse(Console.ReadLine());
            producto.AgregarStock(agregar);

            Console.Write("Cantidad a vender: ");
            int vender = int.Parse(Console.ReadLine());
            decimal total = producto.VenderProducto(vender);

            Console.WriteLine("Total venta: " + total);
            producto.MostrarInfo();
        }

        static void Estudiante()
        {
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Materia: ");
            string materia = Console.ReadLine();

            double[] notas = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            Estudiante est = new Estudiante(nombre, materia, notas);

            Console.WriteLine("Promedio: " + est.CalcularPromedio());
            Console.WriteLine("Estado: " + est.EstadoFinal());
        }

        static void Vehiculo()
        {
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Capacidad del tanque: ");
            double capacidad = double.Parse(Console.ReadLine());

            Console.Write("Rendimiento (km por litro): ");
            double rendimiento = double.Parse(Console.ReadLine());

            Vehiculo v = new Vehiculo(modelo, capacidad, rendimiento);

            Console.Write("Distancia del viaje: ");
            double distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Autonomia: " + v.CalcularAutonomia());

            if (v.NecesitaCombustible(distancia))
                Console.WriteLine("No llega, necesita combustible.");
            else
                Console.WriteLine("Puede realizar el viaje.");
        }
    
    }
}
