using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01
{
    internal class Cubo
    {
        private double _altura { get; set; }

        private double _base { get; set; }

        private double _lateral{ get; set; }       


        public Cubo()
        {
            
        }


        public Cubo(double Altura, double Base, double Lateral)
        {
            this._altura = Altura;
            this._base= Base;
            this._lateral = Lateral;
        }

        public void CalcularVolume()
        {
            double v = this._altura * this._base * this._lateral;
            Console.WriteLine($"Volume: {v} em cm^3");
        }
    }
}


    
   
