using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Murilo", sobrenome:"Galassi");
Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome:"Masarolli");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();














// Pessoa p1 = new Pessoa();
// p1.Nome = "Murilo";
// p1.Sobrenome = "Galassi";
// p1.Idade = 24;
// p1.Apresentar();