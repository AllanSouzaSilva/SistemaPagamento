using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Pagamento.Entidades.Contas
{
    class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial(double saldo, double saque, double deposito, double limiteEmprestimo) :
            base(saldo, saque, deposito)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double emprestimo)
        {
            LimiteEmprestimo -= emprestimo;
            Saldo += emprestimo;
        }
    }

}
