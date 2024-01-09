using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //Class Aluno recebe herança de Pessoa
    {                                                   //se a classe abstrata exigi um atibuto "nome" no caso, pode utilizar no comando um construtor (comando ctor) public Aluno(string nome) : base(nome)
        public Aluno(){

        }
        
        public Aluno(string nome) : base(nome) 
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar() { //override significa sobreescrita, mas o nome da class deve ser o mesmo
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou aluno nota {Nota}");
        }
    }
}