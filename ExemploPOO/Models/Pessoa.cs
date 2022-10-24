using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploPOO.Models
{
    public class Pessoa
    {
        //Método construtor sem parâmetro, nos permite chamar sem passar valor algum.
        public Pessoa()
        {
            
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}, tenho {Idade} anos e meu email é {Email}!");
        }
    }
}