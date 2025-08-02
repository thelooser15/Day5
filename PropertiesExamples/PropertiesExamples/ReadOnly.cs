using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExamples
{
    class Account
    {
        public string Name { get; } = "Pavan";
        public int AccountNumber { get; } = 987654321;

        public string BankName { get; } = "SBI";
    }

    internal class ReadOnly
    {
        static void Main()
        {
            Account account = new Account();
            Console.WriteLine("Account Holders name:"+account.Name);
            Console.WriteLine(account.AccountNumber);
            Console.WriteLine(account.BankName);
        }
    }
}
