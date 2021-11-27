using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoobjeto1
{
    class Motor
    {
        private string _nomeFabricante;
        private int _potencia;
        private string _tipo;

        //public Motor(string nomeFabricante, int potencia, string tipo)
        //{
        //    this.nomeFabricante = nomeFabricante;
        //    this.potencia = potencia;
        //    this.tipo = tipo;
        //}
        //public void informacao()
        //{
        //    Console.WriteLine("NOME: " + this.nomeFabricante + " Potencia: " + this.potencia + " TIPO: " + this.tipo);
        //}

        public string getNomeFabricante()
        {
            return this._nomeFabricante;
        }
        public void setnomeFabricante(string nomeFabricante)
        {
            this._nomeFabricante = nomeFabricante;

        }
        public int potencia
        {
            get
            {
                return _potencia;
            }
            set
            {
                _potencia = value;
            }
        }
        public string tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }
        public void mostradados()
        {
            Console.WriteLine(_nomeFabricante);
            Console.WriteLine(_potencia);
            Console.WriteLine(_tipo);
             


        }


    }
}    