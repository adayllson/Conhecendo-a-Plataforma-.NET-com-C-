using ExemploPOO.Models;

Pessoa p1 = new Pessoa();

Console.WriteLine("Digite seu nome: ");
p1.Nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
p1.Idade = int.Parse(Console.ReadLine());

p1.Apresentar();