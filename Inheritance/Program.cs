using System;
using Heranca.Entities;
namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount acount = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(acount.Balance); //é possível acessar o valor do saldo

            //acount.Balance = 200.0; //não é possível alterar o saldo (pois a prop está como private)
        }
    }
}