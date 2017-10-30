using System;
using System.Collections.Generic;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Cliente1 = new Cliente ();
            Cliente1.nombreCompleto= "Carlos Perez";
            Cliente1.DNI= 30432170;
            Cliente1.Telefono= 46876770;
            Cliente1.FechaDeNacimiento= new DateTime (1983, 1, 2);
            
            Cliente Cliente2 = new Cliente ();
            Cliente2.nombreCompleto= "juan garzia";
            Cliente2.DNI= 30256180;
            Cliente2.Telefono= 46844770;
            Cliente2.FechaDeNacimiento= new DateTime (1980, 11, 12);

            Cuenta NuevaCuenta = new Cuenta ();
            NuevaCuenta.CBU=11110000055;
            NuevaCuenta.Saldo=2000;
           // NuevaCuenta.Titulares.AddRange(Cliente1, Cliente2)?
            NuevaCuenta.Titulares.Add(Cliente1);
            NuevaCuenta.Titulares.Add(Cliente2);
             
            Console.WriteLine ("El saldo de tu cuenta es: " + NuevaCuenta.retirar (1500));
            
            Console.WriteLine ("El saldo de tu cuenta es: " + NuevaCuenta.depositar (200));
            
            foreach (Cliente titular in NuevaCuenta.Titulares)
            {
                Console.WriteLine(titular);
            }
        }
    }
}// f11 para debuguear por linea y meterse adentro. f10 para salir.
