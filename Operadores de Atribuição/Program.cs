﻿using Operadores_de_Atribuição.Models;
int a = 10;
int b = 20;

int c = a + b;
//c = c + 5;
c += 5;
Console.WriteLine(c);

string x = "15-";
int y = 0;
int.TryParse(x, out y);

Console.WriteLine(y);
Console.WriteLine("Conversão realizada com sucesso!");

int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade desejada: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida!");
}
else if (possivelVenda)
{
    Console.WriteLine("Quantidade realizada!");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine()!;

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"A letra {letra} é uma vogal");
        break;
    default:
        Console.WriteLine($"A letra {letra} não é uma vogal");
        break;
}

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(2, 10);
calc.Seno(30);
calc.Conseno(30);
calc.Tangente(30);
calc.RaizQuadrada(144);

// Estrutura de Repetição
// Tabuada

int numero = 5;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}