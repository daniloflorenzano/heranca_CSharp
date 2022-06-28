using System;
using Projeto.Entities;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting
            // uma variavel do tipo Super Classe pode receber qualquer Sub Classe

            Account acc1 = bacc;
        }
    }
}
