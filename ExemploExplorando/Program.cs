using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


int numero = 20;
bool par = false;


par = numero.EhPar();

//If ternário.
string mensagem = "O número " + numero + " é " + (par ? "par" : "ímpar");
Console.WriteLine(mensagem);




// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);






// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");




// var tipoAnonimo = new { Nome = "Adailson", Sobrenome = "Almeida", Altura = 1.80 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);




// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + 
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" + 
//                       $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }


// //Variável booleana aceitando o valor nulo.
// bool? desejaReceberEmail = null;

// //Estrutura condicional que verifica se o valor é diferente de nulo ou se é verdadeiro. 
// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber o email.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber email.");
// }





// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


// int numero = 20;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhas, qtdeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas do arquivo: {qtdeLinhas}");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }

// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }






// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Adailson", "Almeida", 1.80M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");



// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("DF", "Distrito Federal");
// estados.Add("BA", "Bahia");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} => Valor: {item.Value}");
// }


// Console.WriteLine("-----------||------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key} => Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }



// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }



// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }



// try
// {



//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }


// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado." + ex.Message);
// }

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally 
// {
//     Console.WriteLine("Chegou até aqui");
// }






// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"Deu ruim! {dataString} não é uma data válida");
// }




// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// decimal valorMonetario = 10882.40M;

// Console.WriteLine(valorMonetario.ToString("C2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));



// Pessoa p1 = new Pessoa(nome:"Adailson", sobrenome:"Almeida");
// Pessoa p2 = new Pessoa(nome:"Monira", sobrenome:"Aquino");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAluno();
