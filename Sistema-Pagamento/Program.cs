using Sistema_Pagamento.Entidades;
using Sistema_Pagamento.Entidades.Contas;
using System;
using System.Collections.Generic;

namespace Sistema_Pagamento
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        CadastrarUsuarios();
                        break;
                    case "2":
                        ListarCadastros();
                        break;
                    case "3":
                        Alterar();
                        break;
                    case "4":
                        Deletar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção invalida");
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços. ");
            Console.ReadLine();
        }
        private static void CadastrarUsuarios()
        {

            Console.Write("Deseja realizar quantos cadastros ? :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"\n# Cadastro {i}: ");
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("Fazer um deposito? ");
                double deposito = double.Parse(Console.ReadLine());
                Console.Write("Deseja sacar algum valor, se sim quanto? ");
                double saque = double.Parse(Console.ReadLine());

                Console.Write("Pessoa fisica[F] ou juridica[J]?: ");
                char y = char.Parse(Console.ReadLine());
                if (y == 'F' || y == 'f')
                {
                    Console.Write("Digite o CPF: ");
                    string cpf = Console.ReadLine();
                    ContaPF conta = new ContaPF(0, saque, deposito, 0);
                    conta.ClienteDeposito(deposito);
                    conta.ClienteSaque(saque);
                    conta.Poupa();
                    Fisica fisica = new Fisica(nome, idade, cpf, conta);
                    pessoas.Add(fisica);
                }
                else
                {
                    Console.Write("Digite o CNPJ: ");
                    string cnpj = Console.ReadLine();
                    Console.Write("Quantos de emprestimo? : ");
                    double emprestimo = double.Parse(Console.ReadLine());
                    ContaEmpresarial contaPj = new ContaEmpresarial(5000, saque, deposito, 500);
                    Juridica juridica = new Juridica(nome, idade, cnpj, contaPj);
                    contaPj.Emprestimo(emprestimo);
                    contaPj.ClienteDeposito(deposito);
                    contaPj.ClienteSaque(saque);
                    pessoas.Add(juridica);
                }
                Console.WriteLine();
            }

        }
        private static void ListarCadastros()
        {
            foreach (Pessoa dados in pessoas)
            {
                Console.Write("--------------------------------------");
                Console.WriteLine("\n      Dados do cliente:");
                Console.Write("--------------------------------------");
                Console.WriteLine(dados);
            }
        }
        private static void Alterar()
        {
            Console.Write("--------------------------------------");
            Console.WriteLine("\n      Alterar Cliente :");
            Console.Write("--------------------------------------");
            Console.WriteLine("\nDigite o código que deseja alterar: ");
            int cod = int.Parse(Console.ReadLine());

            for (int i = 0; i < pessoas.Count; i++)
            {
                if (cod == pessoas.Count)
                {
                    Console.Write($"\n# Cadastro {i}: ");
                    Console.Write("\nNome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite sua idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Fazer um deposito? ");
                    double deposito = double.Parse(Console.ReadLine());
                    Console.Write("Deseja sacar algum valor, se sim quanto? ");
                    double saque = double.Parse(Console.ReadLine());

                    Console.Write("Pessoa fisica[F] ou juridica[J]?: ");
                    char y = char.Parse(Console.ReadLine());
                    if (y == 'F' || y == 'f')
                    {
                        Console.Write("Digite o CPF: ");
                        string cpf = Console.ReadLine();
                        ContaPF conta = new ContaPF(0, saque, deposito, 0);
                        conta.ClienteDeposito(deposito);
                        conta.ClienteSaque(saque);
                        conta.Poupa();
                        Fisica fisica = new Fisica(nome, idade, cpf, conta);
                        pessoas.Add(fisica);
                    }
                    else
                    {
                        Console.Write("Digite o CNPJ: ");
                        string cnpj = Console.ReadLine();
                        Console.Write("Quantos de emprestimo? : ");
                        double emprestimo = double.Parse(Console.ReadLine());
                        ContaEmpresarial contaPj = new ContaEmpresarial(5000, saque, deposito, 500);
                        Juridica juridica = new Juridica(nome, idade, cnpj, contaPj);
                        contaPj.Emprestimo(emprestimo);
                        contaPj.ClienteDeposito(deposito);
                        contaPj.ClienteSaque(saque);
                        pessoas.Add(juridica);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Código não existe :/ ");
                }
            }
        }
        private static void Deletar()
        {
            Console.Write("--------------------------------------");
            Console.WriteLine("\n      Deletar cliente:");
            Console.Write("\n--------------------------------------");
            foreach (Pessoa remove in pessoas)
            {
                Console.Write("Digite o código que deseja Excluir: ");
                int cod = int.Parse(Console.ReadLine());
                if (cod == pessoas.Count)
                {
                    //pessoa[cod]();
                }
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" System Bank    (   #  B.K  )!!!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Informa a opção desejada: ");
            Console.WriteLine("1 - Inserir novo cadastro");
            Console.WriteLine("2 - Listar cadastros");
            Console.WriteLine("3 - Alaterar");
            Console.WriteLine("4 - Deletar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            string ObterOpcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return ObterOpcaoUsuario;
        }
    }
}

