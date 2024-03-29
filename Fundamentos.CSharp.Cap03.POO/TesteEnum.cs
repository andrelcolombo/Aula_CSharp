using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class TesteEnum
    {
        enum EstadosCivis : byte
        { 
            casado,
            solteiro,
            Viuvo,
            Divorciado,
            Outros
        }

        public void Percorrer()
        {
            foreach (byte i in Enum.GetValues(typeof(EstadosCivis)))
            {
                Console.WriteLine(Enum.GetName(typeof(EstadosCivis), i));
            }
        }
    }
}
