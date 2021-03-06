using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Pagamento.Entidades.Contas
{
    abstract class Conta
    {
        public double Saldo { get; set; }
        public double Saque { get; set; }
        public double Deposito { get; set; }

        public Conta(double saldo, double saque, double deposito)
        {
            Saldo = saldo;
            Saque = saque;
            Deposito = deposito;
        }

        public void ClienteSaque(double saque)
        {
            Saldo -= saque;
        }

        public double ClienteDeposito(double deposito)
        {
             Saldo += deposito;
            return Saldo;
        }
        
        public double AtualizarSaldo()
        {
            return Saldo;
        }
        
    }
}
