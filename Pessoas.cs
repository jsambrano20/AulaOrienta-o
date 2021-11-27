using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoobjeto1
{
    class Pessoas
    {
        private string nome;
        public int idade;
        public string CPF;
        public int anonasc;

        public Pessoas(string nome, int idade, string CPF, int anonasc)
        {
            this.nome = nome;
            this.idade = idade;
            this.CPF = CPF;
            this.anonasc = anonasc;
        }
        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public string getnome()
        {
            return this.nome;
        }

        public void mostranome()
        {
            Console.WriteLine("NOME: " + this.nome);
        }
        public void mostraidade()
        {
            Console.WriteLine("IDADE: " + this.idade);
        }
        public void mostracpf()
        {
            Console.WriteLine("CPF: " + this.CPF);
        }
        public void mostraano()
        {
            Console.WriteLine("ANO DE NASCIMENTO: " + this.anonasc);
        }
    }
}
