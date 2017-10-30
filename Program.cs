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
            Cliente1.DNI= 25432170;
            Cliente1.Telefono= 46876770;
            
            Cliente Cliente2 = new Cliente ();
            Cliente2.nombreCompleto= "juan garzia";
            Cliente2.DNI= 30256180;
            Cliente2.Telefono= 46844770;

            Cuenta NuevaCuenta = new Cuenta ();
            NuevaCuenta.CBU=11110000055;
            NuevaCuenta.Saldo=2000;
            NuevaCuenta.titulares= new List<string> 
            {Cliente1.nombreCompleto, Cliente2.nombreCompleto};

            Console.WriteLine ("El saldo de tu cuenta es: " + NuevaCuenta.retirar (1500));
            
            Console.WriteLine ("El saldo de tu cuenta es: " + NuevaCuenta.depositar (200));
            
        }
    }
}
