using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class Automovel
    { /*
        public string? Fabricante;
        public string? Modelo;
        public string? Placa;
        public string? Cor;
        public short Ano;
      */

        public string? Fabricante;

        private string? _modelo;

        public string? Modelo 
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        

    }
}
