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
            NuevaCuenta.Saldo=2000;
            decimal NuevoSaldo= NuevaCuenta.depositar (1500);
            Console.WriteLine ("El saldo de tu cuenta es: " + NuevoSaldo);
        }
    }
}
