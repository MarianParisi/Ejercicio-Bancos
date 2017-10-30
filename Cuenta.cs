using System;
using System.Collections.Generic;
namespace Banco
{
    public class Cuenta
    {
    public long CBU {get; set;}
    public decimal Saldo {get; set;}
    
    public List<string> titulares { get; set; }
    public decimal depositar ( decimal montoDeposito){
        Saldo = Saldo + montoDeposito;
        return Saldo;
    }
    public virtual decimal retirar ( decimal montoDeposito){
        Saldo = Saldo - montoDeposito;
        return Saldo;
    }
    
    }
}