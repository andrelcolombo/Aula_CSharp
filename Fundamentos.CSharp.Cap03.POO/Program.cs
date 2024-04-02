using Fundamentos.CSharp.Cap03.POO;
using System.Data;

//Automovel carro = new Automovel();

//carro.Fabricante = "VolksWagen";
//carro.Modelo = "GOL";
//carro.Placa = "QUO7H18";
//carro.Cor = "Branco";
//carro.Ano = 2020;

//Console.WriteLine("Fabricante: " + carro.Fabricante);
//Console.WriteLine("Modelo: " + carro.Modelo);
//Console.WriteLine("Placa: " + carro.Placa);
//Console.WriteLine("Cor: " + carro.Cor);
//Console.WriteLine("Ano: " + carro.Ano);

//Colaborador colab = new Colaborador();

//colab.Nome = "Jimmy Page";
//colab.Cargo = "Toca muito";
//colab.Salario = 39.555;

//Console.WriteLine("Nome do colaborador(a): " + colab.Nome);
//Console.WriteLine("Cargo: " + colab.Cargo);
//Console.WriteLine("Salario " + colab.Salario);
//Console.WriteLine("IRPF: " + colab.Irpf);

//Colaborador colab = new Colaborador();

//colab.Atribuir("BillGates", "Estagiario", 680.35);


//TesteEnum enumeradora = new TesteEnum();

//enumeradora.Percorrer();


//Automovel.Fabricante = "VolksWagen";

//Automovel.Modelo = "Gol";

//Console.WriteLine("Fabrincante: " + Automovel.Fabricante);
//Console.WriteLine("Modelo: " + Automovel.Modelo);


//Console.WriteLine(OutroElemStatic.Multiplicar(12, 5));


//var objAnonimo = new
//{
//    Descricao = "Este é um valor de uma prop de um objeto anonimo",
//    DataCriacao = DateTime.Now
//};

//Console.WriteLine("Descrição do objeto: " + objAnonimo.Descricao);
//Console.WriteLine("DataSetDateTime da Criação: " + objAnonimo.DataCriacao);

//Endereco endResidencial = new Endereco();


//endResidencial.Rua = "Rua da CAsinha 01";
//endResidencial.Bairro = "Parque das Flores";
//endResidencial.Cidade = "Vale Paraiso";
//endResidencial.UF = "São Paulo";
//endResidencial.CEP = "03169-060";

//Console.WriteLine(endResidencial.ExibirEndereco());

//struct Endereco 
//{
//    public string? Rua { get; set; }
//    public string? Bairro { get; set; }
//    public string? Cidade { get; set; }
//    public string? UF { get; set; }
//    public string? CEP { get; set; }

//    public string ExibirEndereco() 
//    {
//        return $"Rua: {Rua} \n Bairro: {Bairro} \n Cidade: {Cidade} \n UF: {UF} \n CEP {CEP}";
//    }

//}


Pessoa genteBoa = new Pessoa();


genteBoa.Nome = "Bob Esponja";
genteBoa.Idade = 18;


Console.WriteLine(genteBoa.ExibirDados());

Console.WriteLine(new string('-', 50));

Console.WriteLine(genteBoa.ExibirDados("Hamburgue de siri"));

Console.WriteLine(new string('-', 50));

Console.WriteLine(genteBoa.ExibirDados("Hamburgue de siri", "2"));

Console.WriteLine(new string('-', 50));