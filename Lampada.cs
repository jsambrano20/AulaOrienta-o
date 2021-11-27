using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoobjeto1
{
    class Lampada
    {
        private int ligado;

        /* 0 des*/
        public void ligar()
        {
            Console.WriteLine("Está ligando");
            ligado = 1;
        }
        public void desligar()
        {
            Console.WriteLine("Está desligando");

            ligado = 0;
        }
        public void meialuz()
        {
            Console.WriteLine("ligando meia luz");

            ligado = 2;
        }

        public int estaligado()
        {
            return ligado;
        }



    }
}
