using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_poo.Ejercicios
{
    public class CuentaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public CuentaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine("Saldo actual: " + Saldo);
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
            }
            else
            {
                Console.WriteLine("Cantidad invalida.");
            }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > 0 && cantidad <= Saldo)
            {
                Saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }
    }
}
