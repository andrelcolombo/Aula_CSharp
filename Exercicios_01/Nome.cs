using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01
{
    internal class Nome
    {
        public static string RetornoNome(string PrimeiroNome) 
        {
            return "Seu Primeiro nome é: " + PrimeiroNome;
        }

        public static string RetornoNome(string PrimeiroNome, string NomeDoMeio)
        {
            return "Seu Primeiro e Segundo Nome são: " + PrimeiroNome + " " + NomeDoMeio;
        }

        public static string RetornoNome(string PrimeiroNome, string NomeDoMeio, string TerceiroNome)
        {
            return "Seu Nome Completo é: " + PrimeiroNome + " " + NomeDoMeio + " " + TerceiroNome;
        }
    }
}
