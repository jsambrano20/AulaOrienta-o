using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoobjeto1
{
    class Carro
    {
        private string _modelo;
        private string _cor;
        private int _anoMarca;
        private string _chassi;
        private string _proprietario;
        private int _velocidadeMax;
        private int _velocidadeAtual;
        private int _numPortas;
        private bool _tetoSolar;
        private int _numMarchas;
        private bool _cambioAut;
        private int _volumComb;

        public string getModelo()
        {
            return this._modelo;
        }
        public void setmodelo(string modelo)
        {
            this._modelo = modelo;

        }
        public string cor {get => _cor; set => _cor = value;}
        public int anoMarca
        {
            get
            {
                return _anoMarca;
            }
            set
            {
                _anoMarca = value;
            }
        }
        public string chassi
        {
            get
            {
                return _chassi;
            }
            set
            {
                _chassi = value;
            }
        }
        public string proprietario
        {
            get
            {
                return _proprietario;
            }
            set
            {
                _proprietario = value;
            }
        }
        public int velocidadeMax
        {
            get
            {
                return _velocidadeMax;
            }
            set
            {
                _velocidadeMax = value;
            }
        }
        public int velocidadeAtual
        {
            get
            {
                return _velocidadeAtual;
            }
            set
            {
                _velocidadeAtual = value;
            }

        }
        public int numPortas
        {
            get
            {
                return _numPortas;
            }
            set
            {
                _numPortas = value;
            }

        }
        public bool tetoSolar
        {
            get
            {
                return _tetoSolar;
            }
            set
            {
                _tetoSolar = value;
            }

        }
        public int numMarchas
        {
            get
            {
                return _numMarchas;
            }
            set
            {
                _numMarchas = value;
            }

        }
        public bool cambioAut
        {
            get
            {
                return _cambioAut;
            }
            set
            {
                _cambioAut = value;
            }

        }
        public int volumComb
        {
            get
            {
                return _volumComb;
            }
            set
            {
                _volumComb = value;
            }

        }

        public void acelera()
        {
            if(velocidadeAtual < velocidadeMax)
            {
            this.velocidadeAtual++;
            }

        }
        public void freia()
        {
            if (velocidadeAtual < velocidadeMax)
            {
                this.velocidadeAtual--;
            }
        }
        public void trocaMarcha()
        {
            if (numMarchas < velocidadeAtual)
            {
                this.numMarchas++;
            }
        }
        public void reduzmarcha()
        {
            if (numMarchas > velocidadeAtual)
            {
                this.numMarchas--;
            }
        }
        public void mostraCarro()
        {
            Console.WriteLine(_modelo);
            Console.WriteLine(_cor);
            Console.WriteLine(_anoMarca);
            Console.WriteLine(_chassi);
            Console.WriteLine(_proprietario);
            Console.WriteLine(_velocidadeMax);
            Console.WriteLine(_velocidadeAtual);
            Console.WriteLine(_numPortas);
            Console.WriteLine(_tetoSolar);
            Console.WriteLine(_numMarchas);
            Console.WriteLine(_cambioAut);
            Console.WriteLine(_volumComb);

        }














    }




}




