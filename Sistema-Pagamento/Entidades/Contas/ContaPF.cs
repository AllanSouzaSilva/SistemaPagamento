namespace Sistema_Pagamento.Entidades.Contas
{
    class ContaPF : Conta
    {
        public double Poupanca { get; set; }


        public ContaPF(double saldo, double saque, double deposito, double poupanca) : 
            base(saldo, saque,deposito)
        {
            Poupanca = poupanca;
        }

        public override string ToString()
        {
            return "Saldo:"
                + Saldo
                + "Saque:"
                + Saque
                + "Deposito:"
                + Deposito
                + "Poupança:"
                + Poupanca;
        }
    }
}
