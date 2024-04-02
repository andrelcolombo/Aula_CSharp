using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01
{
    internal class Calculo
    {
  
        private static double ValorEstatico;

        public double ValorSomado { get; set; }

        public static double RecebeValor(double valor) 
        {            
            return ValorEstatico = valor;
        }


        public double Somar() 
        {     
            return ++this.ValorSomado + ValorEstatico;
        }

        public double ValorInicial() 
        {
            return ValorEstatico;
        }       


    }
}
