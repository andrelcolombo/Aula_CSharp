using Exercicios_01;


#region Ex01
/*
Console.WriteLine("Calculo do Volume do Cubo");

Cubo cubo = new Cubo(17, 12, 12);

cubo.CalcularVolume();

Console.ReadKey();
*/
#endregion


#region Ex02
/*
Console.WriteLine(Nome.RetornoNome("André"));

Console.WriteLine(new string('-', 50));

Console.WriteLine(Nome.RetornoNome("André","Luiz"));

Console.WriteLine(new string('-', 50));

Console.WriteLine(Nome.RetornoNome("André", "Luiz", "Colombo"));

Console.WriteLine(new string('-', 50));

Console.ReadKey();
*/
#endregion


#region Ex03
/*
Calculo calcular = new Calculo();

Calculo.RecebeValor(10);


Console.WriteLine(calcular.Somar());

Console.WriteLine(calcular.ValorInicial());

Console.WriteLine(calcular.Somar());

Console.WriteLine(calcular.Somar());
*/
#endregion


#region Ex04

Livro livro1 = new Livro("Guerra Fria", "Um Russo", "Ação", "#1");

livro1.RetornoDados();

Livro livro2 = new Livro("Guerra Mundial Z", "Um Americano", "Ação e Aventura", "#2");

livro2.RetornoDados();

struct Livro 
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public string Registro { get; set; }


    public Livro(string Titulo, string Autor, string Genero, string Registro)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
        this.Genero = Genero;
        this.Registro = Registro;
    }

    public void RetornoDados() 
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"REgistro: {Registro}");
        Console.WriteLine(new string('-', 50));
    }

}
#endregion