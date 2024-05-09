using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopBanco
{
    public class DadosBancarios : ContaCorrente
    {
        public List<string> listDadosBancarios { get; set; }
        
        public DadosBancarios (List<string> dadosBancarios, int idContaCorrente, int agencia, int conta, decimal saldo) 
             : base (idContaCorrente, agencia, conta, saldo)
        {
            listDadosBancarios = dadosBancarios;
        }
    }
}
