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
            Account acc2 = new BusinessAccount(1003, "Joao", 0.0, 600.0);

            // Downcasting
            // conversao de Sub Classe para Super Classe

            BusinessAccount acc3 = (BusinessAccount)acc2;

            if (acc2 is BusinessAccount)
            {
                BusinessAccount acc4 = acc2 as BusinessAccount;
                Console.WriteLine("Loan!");
            }
        }
    }
}
