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

            Console.Write("Deseja realizar quantos cadastros ? : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"# Cadastro {i}:");
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite sua idade:");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Fazer um deposito?");
                double deposito = double.Parse(Console.ReadLine());
                Console.Write("Deseja sacar algum valor?");
                double saque = double.Parse(Console.ReadLine());
                Console.Write("Pessoa fisica[F] ou juridica[J]?");
                char y = char.Parse(Console.ReadLine());
                if (y == 'F' || y == 'f')
                {
                    Console.Write("Digite o CPF:");
                    int cpf = int.Parse(Console.ReadLine());
                    ContaPF conta = new ContaPF(saque, deposito, 100, 10);
                    conta.ClienteDeposito(deposito);
                    conta.ClienteSaque(saque);
                    Fisica fisica = new Fisica(nome, idade, cpf, conta);
                    pessoas.Add(fisica);

                }
                else
                {
                    Console.Write("Digite o CNPJ: ");
                    string cnpj = Console.ReadLine();
                    Console.Write("Quantos de emprestimo? : ");
                    double emprestimo = double.Parse(Console.ReadLine());
                    ContaEmpresarial contaPj = new ContaEmpresarial(0, saque, deposito, 500);
                    Juridica juridica = new Juridica(nome, idade, cnpj, contaPj);
                    contaPj.Emprestimo(emprestimo);
                    contaPj.AtualizarSaldo();
                    contaPj.ClienteDeposito(deposito);
                    contaPj.ClienteSaque(saque);
                    pessoas.Add(juridica);
                }
                Console.WriteLine();
            }
            foreach (Pessoa dados in pessoas)
            {
                Console.Write("----------------------------------");
                Console.Write("      Dados do cliente: \n");
                Console.Write("\n----------------------------------\n");
                Console.WriteLine(dados);
                
            }

        }
    }
}
