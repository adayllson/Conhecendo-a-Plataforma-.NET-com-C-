using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        //Método construtor sem parâmetro, nos permite chamar sem passar valor algum.
        public Aluno()
        {
            
        }
         /* Construtor por herança, chamando atributo da classe Pessoa. 
            Obs. Toda vez que instanciar a classe Pessoa, Aluno ou Professor, 
            obrigatoriamente deverá passar o valor do atributo nome. */
        public Aluno(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou uma aluna nota 10!");
        }
    }
}