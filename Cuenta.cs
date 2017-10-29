using System;

namespace Banco
{
    public class Cuenta
    {
    public long CBU {get; set;}
    public decimal Saldo {get; set;}
    
    public Cliente Titular {get; set;}
    public decimal depositar ( decimal montoDeposito){
        decimal nuevoSaldo = Saldo + montoDeposito;
        nuevoSaldo = Saldo;
        return Saldo;
    }
    public decimal retirar ( decimal montoDeposito){
        decimal nuevoSaldo = Saldo - montoDeposito;
        nuevoSaldo = Saldo;
        return Saldo;

    }
    
    }
}