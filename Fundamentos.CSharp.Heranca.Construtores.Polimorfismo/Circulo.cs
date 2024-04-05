using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Heranca.Construtores.Polimorfismo
{
    //internal class Circulo : Figura
    //{
    //    public double Raio { get; set; }

    //    public Circulo()
    //    {            
    //    }

    //    public Circulo(double raio)
    //    {
    //        this.Raio = raio;
    //    }

    //    public override double CalcularArea()
    //    {
    //        return Math.Pow(this.Raio, 2) * Math.PI;
    //    }
    //}


    public sealed class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo()
        {
        }

        public Circulo(double raio)
        {
            this.Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.Pow(this.Raio, 2) * Math.PI;
        }
    }
}
