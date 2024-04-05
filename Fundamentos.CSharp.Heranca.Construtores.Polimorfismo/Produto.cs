using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Heranca.Construtores.Polimorfismo
{
    internal class Produto
    {
        public string? Nome { get; set; }

        public double Preco { get; set; }

        public virtual string ExibirInfos() 
        {
            return string.Format("Nome: {0}\nPreço: {1}", Nome.ToUpper(), Preco.ToString());
        }
    }
}
