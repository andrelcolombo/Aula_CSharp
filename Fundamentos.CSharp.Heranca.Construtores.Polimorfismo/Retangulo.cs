using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Heranca.Construtores.Polimorfismo
{
    internal class Retangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo() 
        {
            
        }

        public Retangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;            
        }
        public override double CalcularArea()
        {
            return this.Base * Altura;
        }
    }
}
