using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoobjeto1
{
    class Disciplina
    {
        private string nome;
        private int horas;

        public Disciplina(string nome, int horas)
        {
            this.nome = nome;
            this.horas = horas;

        }
        public void exibeInfor()
        {
            Console.WriteLine("NOME DA DISCIPLINA: " + this.nome + "Carga Horária: " + this.horas);
        }





    }
}
