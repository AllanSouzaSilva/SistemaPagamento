using Sistema_Pagamento.Entidades.Contas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Pagamento.Entidades
{
    class Juridica : Pessoa
    {
       
        public string Cnpj { get; set; }
        public ContaEmpresarial ContaPj { get; set; }

        public Juridica(string nome, int idade, string cnpj, ContaEmpresarial contaPj) : base(nome, idade)
        {
            Cnpj = cnpj;
            ContaPj = contaPj;
        }
        public override string ToString()
        {
            return "Nome: " 
                + Nome
                + "Idade: "
                + Idade
                + "Cnpj: "
                + Cnpj
                + "Conta Empresarial: "
                + ContaPj
                ;
        }
    }
}
