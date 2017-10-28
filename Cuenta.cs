using System;

namespace Banco
{
    public class Cuenta
    {
    public long CBU {get; set;}
    public decimal Saldo {get; set;}
    
    public decimal depositar ( decimal montoDepostito){
        decimal Saldo = Saldo + montoDepostito;
        return Saldo;

    }

    
    }
}