using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class OutroElemStatic
    {
        private static int _multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public static int Multiplicar(int v1, int v2) 
        {
            return _multiplicar(v1, v2);
        }
    }
}
