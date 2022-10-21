using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade, decimal salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public decimal Salario { get; set; }
    }
}