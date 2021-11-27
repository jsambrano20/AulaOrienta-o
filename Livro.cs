using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoobjeto1
{
    class Livro
    {
        public string titulo;
        public string autor;
        public string editora;
        public int ano;
        public string genero;
        public string isbn;

        public Livro(string titulo, string autor, string editora, int ano, string genero, string isbn)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.ano = ano;
            this.genero = genero;
            this.isbn = isbn;
        }
        public void mostratitulo()
        {
            Console.WriteLine(titulo);
        }

    }


}


