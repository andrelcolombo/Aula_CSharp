﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Heranca.Construtores.Polimorfismo
{
    public static class Estatica
    {
        public static int Numero1 { get; set; }

        public static void Leitura()
        {
            Console.WriteLine("Este é o valor da prop Numero1: " + Numero1);
        }
    }
}
