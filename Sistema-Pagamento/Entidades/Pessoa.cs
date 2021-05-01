using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Pagamento.Entidades
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        /*public void AdiconarCliente(Pessoa pessoa)
        {
            pessoas.Add();
        }
        public void AlterarCliente(Pessoa pessoa)
        {
            if (Id == pessoa.Id)
            {
                //Redigitar cadastro
            }
        }

        public void DeletarCliente(Pessoa pessoas)
        {
            pessoas.Remover(pessoas);
        }*/
     }
}
