
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