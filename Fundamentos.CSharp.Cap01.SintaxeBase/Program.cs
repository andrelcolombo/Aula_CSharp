// aqui, praticar um comentario de linha

/*
 aqui é um comentario de bloco
*/

/*
 ===============================================================================================================
                                             BLOCO DE INSTRUÇÕES LÓGICAS
 ===============================================================================================================
 */

//1ª abordagem: observar o uso da classe Console com método Writeline() - função e método são as mesmas coisas


//Console.WriteLine("OLÁ MUNDO C#! AQUI, COMEÇA O ESTUDO DA LINGUAGEM ");


// uso do método/função ReadKey

//Console.ReadKey(); // o método ReadKey faz a "leitura" de alguma teclaque foi acessada pelo usuario e,
// assim, a execução da aplicação será interrompida



/* 2ª abordagem: criar uma variavel 

// definição de uma var fazendo uso do tipo primitivo int: esta é umadefinição de var numérica especifica

int umNumero = 3;


// exibir o valor da var umNumero em tela

// abaixo, existe uma concatenação/junção de valores de um "literal de strings"(valor fixo/não se altera) com
// a var umNumero -> estes valores serão exibidos junto em tela - a partir do operador +

Console.WriteLine("Valor original da var um numero é: " + umNumero.ToString());


Console.WriteLine(new string('-', 50)); // a instrução new string() define um objeto do tipo string


// acessar a var umNumero

umNumero = 5;

// acima, por ter definido a var um numero, anteriormente, basta somente acessa-la

Console.WriteLine("O novo valor da var umNumero é: " + umNumero.ToString());

Console.WriteLine(new string('-', 50));

//-----------------------------------------------------------------------------------------------------------


// definir uma var com outro nome

int outroNumero = umNumero;

Console.WriteLine("Valor da var outroNumero " + outroNumero.ToString());

*/

/* 3ª abordagem: operadores de incremento e decremento

// definir uma var com outro data type numerico

byte novoValor; // esta var é, inicialmente, null (nulavel)

// acessar a var 
novoValor = 8;


// fazer uso do operador incremental de uma-em-uma unidade 
Console.WriteLine("Definição do operador Pré-Incremental");
Console.WriteLine("Valor inicial da var novoValor: " + novoValor);
Console.WriteLine("Somando 2 + ++novoValor: " + (2 + ++novoValor));
Console.WriteLine("Valor de novoValor após a 1ª manipulação: " + novoValor);
Console.WriteLine(new string('-', 50));


// acessando var novoValor

novoValor = 10;

// fazer o uso do operador incremental de uma-em-uma unidade
Console.WriteLine("Definição do operador Pós-Incremental");
Console.WriteLine("Valor atual da var novoValor: " + novoValor);
Console.WriteLine("Somando 2 + novoValor++: " + (2 + novoValor++));
Console.WriteLine("Valor de novoValor após a 2ª manipulação: " + novoValor);
Console.WriteLine(new string('-', 50));

//----------------------------------------------------------------


novoValor = 30;
//Fazer o uso do operador decremental de uma-em-uma unidade
Console.WriteLine("Definição do operador Pré-Decremental");
Console.WriteLine("Valor inicial da var novoValor: " + novoValor);
Console.WriteLine("Somando 2 + ++novoValor: " + (2 - --novoValor));
Console.WriteLine("Valor de novoValor após a 1ª manipulação: " + novoValor);
Console.WriteLine(new string('-', 50));


novoValor = 30;
//Fazer o uso do operador decremental de uma-em-uma unidade
Console.WriteLine("Definição do operador Pós-Decremental");
Console.WriteLine("Valor inicial da var novoValor: " + novoValor);
Console.WriteLine("Somando 2 + ++novoValor: " + (2 - novoValor--));
Console.WriteLine("Valor de novoValor após a 1ª manipulação: " + novoValor);
Console.WriteLine(new string('-', 50));
*/

/* 4ª abordagem: operadores relacionais 

// definir algumas vars com declaração multipla de variaveis

byte a = 30, b = 40, c = 50, d = 60; // as vars foram definidas, ao mesmo tempo,
                                     // com o mesmo data type


// exibir os valores das vars

Console.WriteLine("Os valores das vars são: " + a + "\t" + b + "\t" + c + "\t" + d);
Console.WriteLine(new string('-', 50));

// fazer uso dos operadores de relação juntamente com os operadores lógicos AND OR e < > e ==
Console.WriteLine("a < b || c == 50: " + (a < b || c ==50));

// acima, juntamente com os demais codigos que serão implementados, sevirão para observar a relação 
// lógica entre as vars - se são TRUE ou FALSE

Console.WriteLine("a < b || c == d: " + (a < b || c == d));

Console.WriteLine("a > b || c == 50: " + (a > b || c == 50));

Console.WriteLine("a > b || c == d: " + (a > b || c == d));

Console.WriteLine(new string('-', 50));

Console.WriteLine("Uso do operador lógico AND - &&");

Console.WriteLine("a < b || c == 50: " + (a < b || c == 50));

// acima, juntamente com os demais codigos que serão implementados, sevirão para observar a relação 
// lógica entre as vars - se são TRUE ou FALSE

Console.WriteLine("a < b && c == d: " + (a < b && c == d));

Console.WriteLine("a > b && c == 50: " + (a > b && c == 50));

Console.WriteLine("a > b && c == d: " + (a > b && c == d));
*/


/*5ª abordagem: operador ternario


// um operador ternario nada mais é do que uma estrutura de decisão simplificada


// definir uma nova var
byte numero = 23;

// implementar o operador ternario com o proposito de avaliar/
//verificar o valor da var numero

Console.WriteLine(numero + " é " + (numero % 2 == 0 ? "Um Numero Par" : "Um Numero Impar"));

Console.WriteLine(new string('-', 50));


numero = 8;
Console.WriteLine(numero + " é " + (numero % 2 == 0 ? "Um Numero Par" : "Um Numero Impar"));
*/

/* 6ª Abordagem: formatos de saida de dados 

// definir duas vars

string produto = "caneta";

double preco = 6.45;

// estabelecer uma formatação para saída e exibição dos valores das vars

Console.WriteLine(string.Format("Produto: {0}\n Preço: {1:c4}", produto, preco.ToString()));
Console.WriteLine(new string('-', 50));
Console.WriteLine(string.Format("Produto: {0}\n Preço: {1}", produto, preco.ToString("C2")));
Console.WriteLine(new string('-', 50));
*/

/* 7ª Abordagem: uso do recurso CultureInfo*/

// definir uma nova var

double umValor = 1489.35;

Console.WriteLine(umValor.ToString("C2") + "\n\n" + umValor.ToString("C2", new System.Globalization.CultureInfo("en-US")));
