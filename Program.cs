using System;
using CpfExtension;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cpfValidation = CpfValidation.ValidateCpf("07582635621");

            if(cpfValidation == true)
                Console.WriteLine("Valid CPF!");
            else
                Console.WriteLine("Invalid CPF!");
        }
    }
}
