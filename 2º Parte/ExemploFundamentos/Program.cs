using ExemploFundamentos.Common.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("DF");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

Console.WriteLine("Percorrendo a lista com foreach.");
int contadorForeach2 = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição N° {contadorForeach2} - {item}");
    contadorForeach2++;
}




// int [] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine("Percorrendo o array com for.");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}" );
// }

// Console.WriteLine("Percorrendo o array com foreach.");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Adailson";
// pessoa1.Idade = 31;
// pessoa1.Apresentar();

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

// int a = 10;
// int b = 20;

// int c = a + b;
// //c = c + 5;
// c += 5;
// Console.WriteLine(c);

// string x = "15-";
// int y = 0;
// int.TryParse(x, out y);

// Console.WriteLine(y);
// Console.WriteLine("Conversão realizada com sucesso!");

// int quantidadeEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade desejada: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Quantidade realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine()!;

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine($"A letra {letra} é uma vogal");
//         break;
//     default:
//         Console.WriteLine($"A letra {letra} não é uma vogal");
//         break;
// }

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(2, 10);
// calc.Seno(30);
// calc.Conseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(144);

// // Estrutura de Repetição
// // Tabuada

// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int Numero = 7, Contador = 0;

// while (Contador <= 10)
// {
//     Console.WriteLine($"{Numero} x {Contador} = {Numero * Contador++}");

//     if (Contador == 6)
//     {
//         break;
//     }
// }

//  int soma = 0, numero1 = 0;

//  do
//  {
//     Console.WriteLine("Digite um número ou 0 para parar:");
//     numero1 = Convert.ToInt32( Console.ReadLine());
//     soma += numero1;
//  } while(numero1 != 0);

//     Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// string opcao;

// while(true)
// {

//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Remover Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine()!;

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastrar Cliente");
//             break;

//         case "2":
//             Console.WriteLine("Buscar Cliente");
//             break;

//         case "3":
//             Console.WriteLine("Remover Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção Inválida");
//             Console.Clear();
//             break;

//     }
// }