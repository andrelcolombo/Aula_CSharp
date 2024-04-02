using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public string ExibirDados() 
        {
            return string.Format("Nome: {0}\nIdade: {1}", Nome, Idade.ToString());
        }

        public string ExibirDados(string observacao) 
        {
            return string.Format("Nome: {0}\nIdade: {1} anos\nobs.: {2}", Nome, Idade.ToString(), observacao);
        }

        public string ExibirDados(string observacao, string freq) 
        {
            return string.Format("Nome: {0}\nIdade: {1} anos\nobs.: {2}\nFrequencia: {3}", Nome, Idade.ToString(), observacao,freq);
        }
    }
}
 