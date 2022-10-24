using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        //Método construtor sem parâmetro, nos permite chamar sem passar valor algum.
        public Professor()
        {
            
        }
        /* Construtor por herança, chamando atributo da classe Pessoa.
        Obs. Toda vez que instanciar a classe Pessoa, Aluno ou Professor, 
        obrigatoriamente deverá passar o valor do atributo nome. */
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor, e ganho {Salario.ToString("C2")}!");
        }
    }
}