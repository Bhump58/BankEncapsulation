using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAcct = new BankAccount();

            Console.WriteLine(myAcct.Deposit(200));

            Console.WriteLine(myAcct.GetBalance());
        }
    }
}
