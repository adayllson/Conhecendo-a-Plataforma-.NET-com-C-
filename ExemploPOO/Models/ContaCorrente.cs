using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInical)
        {
            NumeroConta = numeroConta;
            saldo = saldoInical;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo indisponível.");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é: {saldo}");
        }
    }
}