
using System;

namespace orientacaoobjeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lampada l = new Lampada();

            //l.ligar();

            //Console.WriteLine("Ligado? " + l.estaligado());

            //l.desligar();

            //Console.WriteLine("Ligado? " + l.estaligado());

            //l.meialuz();

            //Console.WriteLine("Ligado? " + l.estaligado());

            /*
            
             LIVRO
             
             */
            //Livro l = new Livro("Senhor Aneis ", "Autor TESTE ", "Editora TESTE ", 1980 ,"Ficção ", "ABC6535 ");
            ////l.titulo = "Aneis";
            ////l.editora = "Editora Teste";
            ////l.autor = "Autor teste";
            ////l.ano = 1980;
            ////l.genero = "Ficção";
            ////l.isbn = "ABC23456789";
            //Console.WriteLine("Titulo: " + l.titulo + "Editora: " + l.editora);
            //l.mostratitulo();


            /*
             
             PESSOAS

             */
            //Pessoas p = new Pessoas("Joao Sambrano ", 20, "13042995976", 2001);
            //p.mostranome();
            //p.mostracpf();
            //p.mostraano();
            //p.mostraidade();


            /*
             
             DISCIPLINA

             */

            //Curso c = new Curso("Capacitação ");
            //c.exibedis();

            /*

            Motor

             */

            //Motor m = new Motor();
            //m.setnomeFabricante("AUDI");
            //m.potencia = 150;
            //m.tipo = "eletrico ";
            //m.mostradados();


            /*

                CARRO

             */

            Carro c = new Carro();
            c.setmodelo("HATCH");
            c.cor ="preto";
            c.anoMarca = 2022;
            c.chassi = "A51AA255674B";
            c.proprietario = "JOAO";
            c.velocidadeMax = 220;
            c.velocidadeAtual = 100;
            c.numPortas = 4;
            c.tetoSolar = false;
            c.numMarchas = 5;
            c.cambioAut = true;
            c.volumComb = 250;

        }
    }
}
