using System.Reflection;
using System.Security.Cryptography;
using ExemploExplorando.Models;
using Newtonsoft.Json;


int numero = 10;
bool ehPar = false;

//If Ternario
ehPar = numero.EhPar();

string mensagem = "O numero " + numero + " " + "é " + (ehPar ? "par" : "impar");
Console.WriteLine(mensagem);



















// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);


















// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");




















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }













// var tipoAnonimo = new { Nome = "Murilo", Sobrenome = "Galassi", Altura = 1.86};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);















// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                       $"Preço: {venda.Preco} Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//                       $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }



















// bool? desejaReceberEmail = null;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
// }




















//DateTime dataAtual = DateTime.Now;

//List<Venda> listaVendas = new List<Venda>();

//Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
//Venda v2 = new Venda(2, "Licença de Software", 125.00M, dataAtual);

//listaVendas.Add(v1);
//listaVendas.Add(v2);

//string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

//File.WriteAllText("Arquivos/vendas.json", serializado);

//Console.WriteLine(serializado);






















//int numero = 10;
//bool ehPar = false;

//If Ternario
//ehPar = numero % 2 == 0;
//Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));





//if (numero % 2 == 0)
//{
//    Console.WriteLine($"O numero {numero} é par");
//}
//else
//{
//    Console.WriteLine($"O numero {numero} é inpar");
//}

























//Pessoa p1 = new Pessoa("Murilo", "Galassi");

//(string nome, string sobrenome) = p1;


//Console.WriteLine($"{nome} {sobrenome}");




















//LeituraArquivo arquivo = new LeituraArquivo();

//var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

//if (sucesso)
//{
//    Console.WriteLine("Quantidade de linha: " + quantidadeLinhas);
//    foreach (string linha in linhasArquivos)
//    {
//        Console.WriteLine(linha);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possivel ler o arquivo");
//}























//(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (10, "Murilo", "Galassi", 1.86M);

//ValueTuple<int, string, string, decimal> outroExemploTupla = (10, "Murilo", "Galassi", 1.86M);
//var outroExemploTuplaCreate = Tuple.Create(10, "Murilo", "Galassi", 1.86M);


//Console.WriteLine($"Id: {tupla.Id}");
//Console.WriteLine($"Nome: {tupla.Nome}");
//Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
//Console.WriteLine($"Altura: {tupla.Altura}");


















//Dictionary<string, string> estados = new Dictionary<string, string>();

//estados.Add("SP", "São Paulo");
//estados.Add("BA", "Bahia");
//estados.Add("MG", "Minas Gerais");
//estados.Add("RJ", "Rio de Janeiro");

//foreach(var nome in estados)
//{
//    Console.WriteLine($"Chave: {nome.Key}, Valor: {nome.Value}");
//}

//Console.WriteLine("-------------");

//estados.Remove("RJ");
//estados["SP"] = "São Paulo - valor alterado";

//foreach(var nome in estados)
//{
//    Console.WriteLine($"Chave: {nome.Key}, Valor: {nome.Value}");
//}















// Stack<int> pilha = new Stack<int>();

// pilha.Push(10);
// pilha.Push(20);
// pilha.Push(30);
// pilha.Push(40);

// foreach(int item in pilha)
// {

//     Console.WriteLine(item);

// }

// Console.WriteLine($"Removendo o elemento do top: {pilha.Pop()}");

// pilha.Push(50);

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
// fila.Enqueue(10);

// foreach(int item in fila)
// {

//     Console.WriteLine(item);

// }























//new ExemploExcecao().Metodo1();












// try
// {

//   string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//   foreach(string linha in linhas)
//   {
//      Console.WriteLine(linha);
//   }

// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivos. Arquivo não encontrado. {ex.Message}");
// }

// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura de arquivo. Caminho da pasta não encontrado {ex.Message}");
// }

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally 
// {
//     Console.WriteLine("Chegou ate aqui");
// }



















// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"{valorMonetario:C}");



















// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);



















// Pessoa p1 = new Pessoa(nome: "Murilo", sobrenome:"Galassi");
// Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome:"Masarolli");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();














// Pessoa p1 = new Pessoa();
// p1.Nome = "Murilo";
// p1.Sobrenome = "Galassi";
// p1.Idade = 24;
// p1.Apresentar();