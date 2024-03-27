// definir duas vars

using System.Diagnostics;

int umValor;
int outroValor;

// acessar as vars e atribuir valores
Console.WriteLine("1ª abordagem \n");

umValor = 15;
outroValor = 55;


// definir a estrutura de decisão com a expressão de avaliação
if (umValor < outroValor) // a instrução if é, necessariamente, uma instrução que pratica uma avaliação booleana -->
                          // só pode oferecer como resposta TRUE ou FALSE
{   
    // se a avaliação do teste for considerada TRUE aquilo que estiver descrito abaixo
    // será, então, executada como tarefa
    Console.WriteLine(umValor + " é menor que " + outroValor);
}

Console.WriteLine(new string('-', 50));

//-------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("2ª abordagem \n");

umValor = 20;
outroValor = 13;

if (umValor < outroValor) // aqui, a avaliação será observada como falsa
    //false --> outroValor fluxo do código será interrompido
{
    Console.WriteLine(umValor + " é menor que " + outroValor);
}

Console.WriteLine(new string('-', 50));

//-------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("3ª abordagem \n");

// acessar as vars
umValor = 32;
outroValor = 11;

if (umValor < outroValor)
{
    Console.WriteLine(umValor + " é menor que " + outroValor);
}
else // se não - se for FALSE - exiba auilo que estiver descrito no bloco de instruções abaixo
{
    Console.WriteLine(umValor + " é maior que " + outroValor);
}

Console.WriteLine(new string('-', 50));

//-------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("4ª abordagem: observar if/else aninhamento \n");

// acessar as vars

umValor = 89;
outroValor = 89;

// definir a estrutura de decisão considerando uma possivel igualdade de valores das vars
if (umValor < outroValor)
{
    Console.WriteLine(umValor + " é menor que " + outroValor);
}

else if (umValor == outroValor) 
{
    Console.WriteLine(umValor + " é igual a " + outroValor);
}

else // se não - se for FALSE - exiba auilo que estiver descrito no bloco de instruções abaixo
{
    Console.WriteLine(umValor + " é maior que " + outroValor);
}

Console.WriteLine(new string('-', 50));

//-------------------------------------------------------------------------------------------------------------------------------
/*
// INSTRUÇÕES DE DECISÃO E CONTROLE SWITCH/CASE

Console.WriteLine("Switch/case - 1ª abordagem \n");

// definir alguns recursos necessários para as proximas abordagens

Console.WriteLine("Informe um numero entre o intervalo de 1 a 7");

// definir uma var para receber como valor o dado que o usuario informar
string diaSemana = Console.ReadLine(); // esta instrução proporciona a captura de valor inserido - via terminal/prompt -
                                       // pelo usuario


// definir uma nova var - vazia

string resultado = ""; // a var recebeu como valor uma string vazia


// verificar se existe algum valor atribuido a var diaSemana
if (diaSemana.Trim() == "")// Trim() -> é responsavel por "limpar" a entrada de dados recebida pela aplicação

    // TRUE/FALSE
{ 
    return; // aqui, só pode ser retornada uma unica situação: a var diaSemana vazia!
}

// se o usuario inserir um valor valido - o bloco de código abaixo passa a ser executado

switch (diaSemana) // switch() usa a var diaSemana como expressão de teste
{
    // abaixo serão descritos os valores/casos/cenarios que ficam a disposição para uma seleção
    // e exibição a partir de um valor dado a var diaSemana

    case "1":
        resultado = "Domingo";
        break;

    case "2":
        resultado = "Segunda";
        break;

    case "3":
        resultado = "Terça";
        break;

    case "4":
        resultado = "Quarta";
        break;

    case "5":
        resultado = "Quinta";
        break;

    case "6":
        resultado = "Sexta";
        break;

    case "7":
        resultado = "Sabado";
        break;

    // caso o usuario informe um valor que não esteja em conformidade com os cenarios
    // previstos acima, podemos definir uma ocorrencia-padrão para este contexto
    default:
        resultado = "Valor informado invalido";
        break;
}


// exibir o valor da var resultado
Console.WriteLine("O valor indicado corresponde a: " + resultado);

*/



/*2ª abordagem


// INSTRUÇÕES DE DECISÃO E CONTROLE SWITCH/CASE

Console.WriteLine("Switch/case - 1ª abordagem \n");

// definir alguns recursos necessários para as proximas abordagens

Console.WriteLine("Informe um numero entre o intervalo de 1 a 7");

// definir uma var para receber como valor o dado que o usuario informar
string diaSemana = Console.ReadLine(); // esta instrução proporciona a captura de valor inserido - via terminal/prompt -
                                       // pelo usuario


// definir uma nova var - vazia

string resultado = ""; // a var recebeu como valor uma string vazia


// verificar se existe algum valor atribuido a var diaSemana
if (diaSemana.Trim() == "")// Trim() -> é responsavel por "limpar" a entrada de dados recebida pela aplicação

// TRUE/FALSE
{
    return; // aqui, só pode ser retornada uma unica situação: a var diaSemana vazia!
}

// se o usuario inserir um valor valido - o bloco de código abaixo passa a ser executado

switch (diaSemana) // switch() usa a var diaSemana como expressão de teste
{
    // abaixo serão descritos os valores/casos/cenarios que ficam a disposição para uma seleção
    // e exibição a partir de um valor dado a var diaSemana

    case "1":
        resultado = "Domingo - dia de descanso";
        break;

    case "2":
        

    case "3":
        

    case "4":
       

    case "5":
        

    case "6":
        resultado = "Estes são considerados dias uteis";
        break;

    case "7":
        resultado = "Sabado";
        break;

    // caso o usuario informe um valor que não esteja em conformidade com os cenarios
    // previstos acima, podemos definir uma ocorrencia-padrão para este contexto
    default:
        resultado = "Valor informado invalido";
        break;
}


// exibir o valor da var resultado
Console.WriteLine("O valor indicado corresponde a: " + resultado);

*/


// --------------------------------------------------------------------------------------------------------------------------------


/*3ª abordagem - switch/case expression (expressão switch/case)*/



// 2º passo: tentativa de acesso a enum e, de dentro dela, acessar uma de suas props/valores. Para este proposito,
// será definida uma var com o tipo construido  periodo -> significa que: a enum definida por nós será a definição
// de tipo de uma var

Periodo tempinho = Periodo.V;

// 3º passo: definir uma nova var com tipo primitivo string
string descrição;


// 4º passo: construir o bloco switch/case - a partir da expressão

// o uso do caracter _ (discard/underscore) dis, a partir do C#,
// que não deseja usar nenhum valor explicito/expecifico para atribuir 
//algum valor de expressão - "é uma indicação semelhante a uma var anônima"

_ = (tempinho switch
{ 
    Periodo.M => descrição = "Manhã", // a sigla M determina que o valor associado a ela é a string Manhã
    Periodo.T => descrição = "Tarde",
    Periodo.V => descrição = "Vespertino",
    Periodo.N => descrição = "Noite",

    // expressão-padrão
    _=> descrição = "Periodo desconhecido"
});

// 5ª passo: exibir o resultado
Console.WriteLine("Periodo selecionado: " + descrição);


// 1º passo: definir uma enum - data type que possibilita a descrição de um conjunto de valores imutaveis,
// simples, que podem ser acessados de forma direta, para operações
enum Periodo
{ 
    M, T, V, N // significado das siglas: m -> manhã, T -> tarde, V -> vespertino, N -> noite
}