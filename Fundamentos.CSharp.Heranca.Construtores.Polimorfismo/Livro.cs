using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Heranca.Construtores.Polimorfismo
{
    internal class Livro : Produto
    {
        public short Npaginas {  get; set; }
              
        public override string ExibirInfos()
        {
            return base.ExibirInfos() + "\nNumero de paginas: " + Npaginas.ToString();
        }
    }
}
