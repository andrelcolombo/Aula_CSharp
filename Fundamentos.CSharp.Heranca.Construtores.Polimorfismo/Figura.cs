using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Heranca.Construtores.Polimorfismo
{
    public abstract class Figura
    {
        public abstract double CalcularArea();

        public string ExibirInfosDaAbstract() 
        {
            string nomeClasse = this.GetType().Name;
            double area = this.CalcularArea();
            return $"classe: {nomeClasse}\nArea: {area}";
        }
    }
}
