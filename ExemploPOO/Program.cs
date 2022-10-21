using ExemploPOO.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Adailson";
p1.Idade = 31;
p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

Aluno a1 = new Aluno("Monira", 26, 9.5);
a1.Apresentar();

Professor pf = new Professor("Pedro", 0, 10000);
pf.Apresentar();


