/*
 loops são: while e do/while -> indefinidos porque oferecem 
 2 infos: onde parar e como parar

for e foreach -> definidos porque oferecem 3 infos: o ponto inicial, o ponto final e 
como se sai do ponto inicial e se chega no ponto final
 */


// INSTRUÇÕES PARA OS LOOP WHILE

/*LOOP WHILE

// 1º passo: definir uma variavel com um valor inicial
short num = 1000;

// 2º passo: definição do loop while - classificado como indefinido
while (num <= 5000) // esta é a expressão de teste do loop. significa que:
                   // enquanto esta expressão de avaliação for considerada TRUE o loop permanecerá em execução
{
    // ao avaliar a expressão de teste, queremos que seja repetida a instrução abaixo
    Console.WriteLine("O valor da var num, agora, é: " + num);

    // a instrução abaixo, em algum momento, tornara a expressão de avaliação FALSE. Ássim, o loop se interrompe

    num += 1000;
}

*/


/*
 LOOP DO/WHILE
 

// definir uma var

using System;

int umNumero = 8000;

// definir o loop do/while

do // faça algo -> independente da expressão de teste do loop
{
    Console.WriteLine("O valor da var umNumero, é: " + umNumero);

    umNumero += 1000;

} while (umNumero < 1000);
*/

/*INSTRUÇÕES PARA ESTABELECER OS LOOPS DEFINIDOS - LOOPS FOR*/

/*LOOP FOR

// 1ª abordagem do loop for
// podemos chamar esta definição de loop de: "definição direta/
// tradicional" porque tudo aquilo que o loop precisa para seu pleno
// funcionamento já esta declarado em sua definição

for (int a = 1, b = 1; a < 300 || b < 300; a *= 3, b *=2)
{
    // exibir os valores das vars
    Console.WriteLine("valores da var 'a': " + a);
    Console.WriteLine("valores da var 'b': " + b);
    Console.WriteLine(new string('-', 50));
}

*/

/*2ª abordagem: comando break

for (int a = 1; a <= 1000; a++)
{
    // para uso da expressão/comando break - dentro do loop - é necessario estabelecer uma verificação de valor da var iterado/auxiliar
    if (a > 20) 
    {
        break;
    }

    Console.WriteLine("Valor de 'a': " + a);
}
*/


/*3ª abordagem: comando continue

for (int i = 1; i <= 20; i++)
{
    if (i > 3 && i < 5 )
    {
        continue;
    }

    Console.WriteLine("Valor da var 'i': " + i);
}
*/

/*4ª abordagem: loop de alfabeto

for (char l = 'a'; l <= 'z'; l++)
{
    Console.Write(l + " ");
}

Console.WriteLine();
Console.WriteLine(new string('-', 50));

for (char l = 'z'; l >= 'a'; l--)
{
    Console.Write(l + " ");
}
Console.WriteLine();*/


/*LOOP FOREACH*/

// definição do loop foreach - iterar sobre os valores de um determinado conjunto de dados... desde que este consuto de dados/valores exista.

// criar um conjunto de valores de mesmo tipo - data type
string[] listaPaises = {"Alemanha", "Argentina", "Brasil", "França", "Gana", "Uruguai" };


//definir o loop forech para iterar/percorrer o conjunto de dados (array listaPaises)
foreach (string pais in listaPaises) 
{    

    if (pais.StartsWith("A"))
    {
        Console.WriteLine(pais.ToUpper());
    }

    Console.WriteLine(new string('-', 50));

    if (pais.Contains("n")) 
    {
        Console.WriteLine(pais.ToUpper());
    }


}

