namespace Sistema_Pagamento.Entidades.Contas
{
    class ContaPF : Conta
    {
        public double Poupanca { get; set; }


        public ContaPF(double saldo, double saque, double deposito, double poupanca) :
            base(saldo, saque, deposito)
        {
            Poupanca = poupanca;
        }

        public double Poupa()
        {
            return Saldo += Poupanca;
        }
    }
}
