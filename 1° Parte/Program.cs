using Sintaxe_e_Indentação.Models;
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Adailson";
pessoa1.Idade = 31;
pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));