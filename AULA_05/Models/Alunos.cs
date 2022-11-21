using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA_05.Models
{
    public class Alunos: Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos! Sou um aluno de nota {Nota}");
        }
    }
}