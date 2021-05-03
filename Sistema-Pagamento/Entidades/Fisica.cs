using Sistema_Pagamento.Entidades.Contas;

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
            return "Nome: "
                    + Nome
                    + ", Idade: "
                    + Idade
                    + ", Cpf: "
                    + Cpf
                    + ", Saldo "
                    + Conta.Saldo
                    + ", Saque: "
                    + Conta.Saque
                    + ", Deposito: "
                    + Conta.Deposito
                    + ", Poupança: "
                    + Conta.Poupanca
                    ;
        }
    }


}
