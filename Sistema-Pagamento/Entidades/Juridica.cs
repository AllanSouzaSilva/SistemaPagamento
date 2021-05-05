using Sistema_Pagamento.Entidades.Contas;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            return "\nNome: "
                + Nome
                + "\nIdade:"
                + Idade + " Anos"
                + "\nCnpj: "
                + Cnpj
                + "\nDeposito: "
                + ContaPj.Deposito.ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                + "\nSaque: "
                + ContaPj.Saque.ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                + "\nLimite de emprestimo: "
                + ContaPj.LimiteEmprestimo.ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                + "\n--------------------------------------"
                + "\nSaldo Final: "
                + ContaPj.AtualizarSaldo().ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                + "\n--------------------------------------"
                ;
        }
    }
}
