using System;

namespace abstruct_Bank_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Account a1 = new Savings("Savings", "xxx", 70000, 6);
            Account a2 = new Fixed("Fixed", "xxx", 6000, 2020, 5);
            a1.Withdraw(100);
            a2.Withdraw(4000);
           

        }
    }
}
