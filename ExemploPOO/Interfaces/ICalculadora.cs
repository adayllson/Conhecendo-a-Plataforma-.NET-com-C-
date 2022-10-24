using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        //Métodos que não tem corpo (bloco de código) são obrigatórios para implementação da interface.
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        //Métodos que tem corpo (bloco de código) são opcionais para a implementação da interface. Exemplo: Método Dividir.
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}