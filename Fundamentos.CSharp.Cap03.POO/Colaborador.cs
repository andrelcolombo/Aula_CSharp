using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Fundamentos.CSharp.Cap03.POO
{
    internal class Colaborador
    {

        //private string? _nome;

        //public string Nome
        //{
        //    get { return _nome; }
        //    set { _nome = value; }
        //}

        //private string? _cargo;

        //public string Cargo
        //{
        //    get { return _cargo; }
        //    set { _cargo = value; }
        //}


        //private double _salario;


        //public double Salario
        //{
        //    get { return _salario; }

        //    set { _salario = value; }
        //}


        //public double Irpf
        //{             
        //    get { return _salario * 0.1; }         
        //}



        //private string? _nome;

        //public string Nome
        //{
        //    get => _nome;
        //    set => _nome = value;
        //}

        //private string? _cargo;

        //public string Cargo
        //{
        //    get => _cargo; 
        //    set => _cargo = value; 
        //}


        //private double _salario;


        //public double Salario
        //{
        //    get => _salario; 

        //    set => _salario = value; 
        //}


        //public double Irpf
        //{
        //    get => _salario * 0.1; 
        //}

        //public string? Nome { get; set; }
        //public string? Cargo { get; set; }
        //public double Salario { get; set; }
        //public double Irpf => Salario * 0.3;

        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public double Salario { get; set; }

        public void Atribuir(string Nome, string Cargo, double Salario) 
        {
            this.Nome = Nome;
            this.Cargo = Cargo;
            this.Salario = Salario;

            Console.WriteLine("Nome: " + Nome + "\nCargo: " + Cargo + "\nSalario: " + Salario);
        }



    }
}
