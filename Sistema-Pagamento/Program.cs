using Sistema_Pagamento.Entidades;
using Sistema_Pagamento.Entidades.Contas;
using System;
using System.Collections.Generic;

namespace Sistema_Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Console.WriteLine("Cadastrar quantos? :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite sua idade:");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Fazer um deposito?");
                double deposito = double.Parse(Console.ReadLine());
                Console.WriteLine("Deseja sacar algum valor?");
                double saque = double.Parse(Console.ReadLine());
                Console.WriteLine("Pessoa fisica[F] ou juridica[J]?");
                char y = char.Parse(Console.ReadLine());
                if (y == 'F' || y == 'f')
                {
                    Console.WriteLine("Digite o CPF:");
                    int cpf = int.Parse(Console.ReadLine());
                    ContaPF conta = new ContaPF(saque, deposito, 100, 10);
                    Fisica fisica = new Fisica(nome, idade, cpf, conta);
                    pessoas.Add(fisica);

                }
                else
                {

                    Console.WriteLine("Digite o CNPJ: ");
                    string cnpj = Console.ReadLine();
                    ContaEmpresarial contaPj = new ContaEmpresarial(0, saque,deposito,500);
                    Juridica juridica = new Juridica(nome, idade, cnpj, contaPj);
                    pessoas.Add(juridica);


                }
                
            }
            foreach (Pessoa i in pessoas)
            {
                Console.WriteLine(i);
            }

        }
    }
}
