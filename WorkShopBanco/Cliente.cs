using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopBanco
{
    public class Cliente
    {
        private int intIdCliente { get; set; }
        private string strNome { get; set; }
        private int intRG_IE { get; set; }
        private int intCPF_CNPJ { get; set; }
        private DateTime dtNascimento { get; set; }

        public Cliente(int idCliente, string nome, int RG_IE, int CPF_CNPJ, DateTime nascimento, string endereco, string numero, string complemento, string bairro, string municipio, string estado, int CEP)
        {
            intIdCliente = idCliente;
            strNome = nome;
            intRG_IE = RG_IE;
            intCPF_CNPJ = CPF_CNPJ;
            dtNascimento = nascimento;
        }
    }
}
