using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopBanco
{
    public class Endereco
    {
        private string strEndereco { get; set; }
        private string strNumero { get; set; }
        private string strComplemento { get; set; }
        private string strBairro { get; set; }
        private string strMunicipio { get; set; }
        private string strEstado { get; set; }
        private int intCEP { get; set; }

        public Endereco(string endereco, string numero, string complemento, string bairro, string municipio, string estado, int CEP)
        {
            strEndereco = endereco;
            strNumero = numero;
            strComplemento = complemento;
            strBairro = bairro;
            strMunicipio = municipio;
            strEstado = estado;
            intCEP = CEP;
        }
    }
}
