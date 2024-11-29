using System.Reflection;
using ExemploExplorando.Models;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");

foreach(var nome in estados)
{
    Console.WriteLine($"Chave: {nome.Key}, Valor: {nome.Value}");
}

Console.WriteLine("-------------");

estados.Remove("RJ");
estados["SP"] = "São Paulo - valor alterado";

foreach(var nome in estados)
{
    Console.WriteLine($"Chave: {nome.Key}, Valor: {nome.Value}");
}















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