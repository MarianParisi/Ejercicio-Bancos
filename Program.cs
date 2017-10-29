using System;


namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente NuevoCliente = new Cliente ();
            NuevoCliente.nombreCompleto= "Carlos Perez";
            NuevoCliente.DNI= 25432170;
            NuevoCliente.Telefono= 46876770;
            
            Cuenta NuevaCuenta = new Cuenta ();
            NuevaCuenta.Titular=NuevoCliente;
            NuevaCuenta.Saldo=2000;
            Console.WriteLine ("El saldo de tu cuenta es: " + NuevaCuenta.retirar (1500));
            Console.WriteLine(NuevaCuenta.Titular.nombreCompleto);
            Console.WriteLine ("El saldo de tu cuenta es: " + NuevaCuenta.depositar (200));
            
        }
    }
}
