using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopBanco
{
    public class ContaCorrente
    {
        public int intIdContaCorrente { get; set; }
        public int intAgencia { get; set; }
        public int intConta { get; set; }
        public decimal decSaldo { get; set; }       
        
        public ContaCorrente(int idContaCorrente, int agencia, int conta, decimal saldo)
        {
            intIdContaCorrente = idContaCorrente;
            intAgencia = agencia;
            intConta = conta;
            decSaldo = saldo;
        }
    }
}
