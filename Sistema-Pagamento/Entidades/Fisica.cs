using Sistema_Pagamento.Entidades.Contas;
using System.Globalization;

namespace Sistema_Pagamento.Entidades
{
    class Fisica : Pessoa
    {
        public int Cpf { get; set; }
        public ContaPF Conta { get; set; }


        public Fisica(string nome, int idade, int cpf, ContaPF conta) : base(nome, idade)
        {
            Cpf = cpf;
            Conta = conta;
        }
        
        public override string ToString()
        {
            return "\nNome: "
                    + Nome
                    + "\nIdade: "
                    + Idade + " Anos"
                    + "\nCpf: "
                    + Cpf
                    + "\nDeposito: "
                    + Conta.Deposito.ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                    + "\nPoupança:"
                    + Conta.Poupa().ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                    + "\nSaque: "
                    + Conta.Saque.ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                    + "\n--------------------------------------"
                    + "\nSaldo Final: "
                    + Conta.AtualizarSaldo().ToString("F2", CultureInfo.InvariantCulture) + " Reais"
                    + "\n--------------------------------------"
                    ;
          
        }
    }


}
