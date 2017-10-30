using System;
using System.Collections.Generic;
namespace Banco
{
    public class Cuenta
    {
    public long CBU {get; set;}
    public decimal Saldo {get; set;}
    // en caso de que hay un solo titular
    // public Cliente Titular {get; set;}
    public List<Cliente> Titulares { get; set; }
    public decimal depositar ( decimal montoDeposito){
       /* Saldo = Saldo + montoDeposito;
        return Saldo;*/
        this.Saldo += montoDeposito;
        return this.Saldo;
    }
    public virtual decimal retirar ( decimal montoDeposito){

       /* Saldo = Saldo - montoDeposito;
        return Saldo;*/

        this.Saldo -= montoDeposito;
        return this.Saldo;
    }
    
    public Cuenta()
    {
        this.Saldo=0;
        this.Titulares= new List<Cliente>();
    }
    }
}