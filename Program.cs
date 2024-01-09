using ExemploPOO.Models;
useing ExemploPOO.Interfaces;

//ICalculadora calc = new ICalculadora(); Errado: Interfaces não podem ser instanciadas
ICalculadora calc = new Calculadora(); // mas pode chmar a interface ICalculador para receber Calculadora, porque Calculadora impllementa interface
Console.WriteLine(calc.Multiplicar(3,9));




















// Computador c = new Computador(); //isso significa intanciar a classe computaodr
// c.ToString();
// Console.WriteLine(c.ToString());















// Pessoa p1 = new Pessoa("Hirla");
// Aluno a1 = new Aluno("Laura");
// a1.Apresentar();
// Professor prof = new Professor();













// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();








// Aluno a1 = new Aluno();
// a1.Nome = "Hirla";
// a1.Idade = 19;
// a1.Email = "hhirlaandrade@gmail.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Hirla";
// p1.Idade = 19;
// p1.Salario = 3000;
// p1.Apresentar();



// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();










// Pessoa p1 = new Pessoa();
// p1.Nome = "Hirla";
// p1.Idade = 19;

// p1.Apresentar();