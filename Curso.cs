using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoobjeto1
{
    class Curso
    {
        public string nome;
        public Curso(string nome)
        {
            this.nome = nome;
         }

        public void exibedis()
        {
            Disciplina d = new Disciplina("C#", 120);
            d.exibeInfor();
        }
    }
}
